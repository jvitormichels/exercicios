require 'rails_helper'

RSpec.describe "Weapons", type: :request do
    describe "GET /weapons" do
        it "should return status 200" do
            get weapons_path
            expect(response).to have_http_status(200)
        end

        it "lists the titles correctly" do
            weapons = create_list(:weapon, 3)
            get weapons_path
            weapons.each do |weapon|
                expect(response.body).to include(weapon.title)
            end
        end

        it "lists the current power correctly" do
            weapons = create_list(:weapon, 3)
            get weapons_path
            weapons.each do |weapon|
                expect(response.body).to include(weapon.current_power.to_s)
            end
        end

        it "show weapon's details" do
            weapons = create_list(:weapon, 3)
            weapons.each do |weapon|
                get("/weapons/#{weapon.id}")
                expect(response.body).to include(weapon.title, weapon.description)
            end
        end

        it "deletes the weapon" do
            weapon = create(:weapon)
            delete "/weapons/#{weapon.id}"
            expect{ weapon.reload }.to raise_error(ActiveRecord::RecordNotFound)
        end
    end

    describe "POST /weapons" do
        context "when it has valid parameters" do
            it "creates the weapon with correct parameters" do
                weapon_attributes = FactoryBot.attributes_for(:weapon)
                post weapons_path, params: { weapon: weapon_attributes }
                expect(Weapon.last).to have_attributes(weapon_attributes)
            end
        end

        context "when it has no valid parameters" do
            it "does not create the weapon" do
                expect {
                    post weapons_path, params: { weapon: { name: '', description: '', power_base: '', power_step: '', level: ''}}
                }.to_not change(Weapon, :count)
            end
        end
    end
end