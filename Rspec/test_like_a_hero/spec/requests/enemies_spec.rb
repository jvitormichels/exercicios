require 'rails_helper'

RSpec.describe "Enemies", type: :request do
  describe "GET /enemies" do
    context "when the enemy exists" do
      let(:enemy) { create(:enemy) }

      before(:each) { get "/enemies/#{enemy.id}" }
      it "returns status code 200" do
          expect(response).to have_http_status(200)
      end

      it "shows the enemy data" do
        expect(response.body).to include(enemy.title, enemy.current_power.to_s)
      end
    end

    context "when the enemy doesn't exist" do
      it "returns status code 404" do
        expect{ get '/enemies/0' }.to raise_error(ActionView::Template::Error)
      end
    end
  end

  describe "PUT /enemies" do
    context "when the enemy exists" do
      let(:enemy) { create(:enemy) }
      let(:enemy_attributes) { attributes_for(:enemy) }

      before(:each) { put "/enemies/#{enemy.id}", params: { enemy: enemy_attributes } }
      
      it "returns status code 200" do
        expect(response).to have_http_status(200)
      end

      it "updates the record" do
        expect(enemy.reload).to have_attributes(enemy_attributes)
      end

      it "returns the enemy updated" do
        expect(enemy.reload).to have_attributes(json.except('created_at', 'updated_at'))
      end
    end

    context "when the enemy does not exist" do
      before(:each) { put '/enemies/0', params: attributes_for(:enemy) }

      it "returns status code 404" do
        expect(response).to have_http_status(404)
      end

      it "returns a not found message" do
        expect(response.body).to match(/Couldn't find Enemy/)
      end
    end
  end

  describe "DELETE /enemies" do
    context "when the enemy exists" do
      let(:enemy) { create(:enemy) }
      
      before(:each) { delete "/enemies/#{enemy.id}" }

      it "returns status code 204" do
        expect(response).to have_http_status(204)
      end

      it "destroy the record" do
        expect{ enemy.reload }.to raise_error ActiveRecord::RecordNotFound
      end
    end

    context "when the enemy does not exist" do
      before(:each) { delete '/enemies/0' }
      
      it "returns a status code 404" do
        expect(response).to have_http_status(404)
      end

      it "returns a not found message" do
          expect(response.body).to match(/Couldn't find Enemy/)
      end
    end
  end

  describe "CREATE /enemies" do
    context "with valid parameters" do
      it "creates the enemy" do
        enemy_attributes = FactoryBot.attributes_for(:enemy)
        post enemies_path, params: { enemy: enemy_attributes }
        expect(Enemy.last).to have_attributes(enemy_attributes)
      end
    end

    context "with invalid parameters" do
      it "doesn't create the enemy" do
        expect {
          post enemies_path, params: { enemy: { name:'', power_base:'', power_step:'', level:'',kind:'' } }
        }.to_not change(Enemy, :count)
      end
    end
  end
end
