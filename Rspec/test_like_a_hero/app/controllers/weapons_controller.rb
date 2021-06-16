class WeaponsController < ApplicationController
    
    def index
        @weapons = Weapon.order(name: :asc)
    end

    def create
        @weapon = Weapon.create(weapon_params)
        redirect_to weapons_path
    end

    def destroy
        weapon = set_weapon
        weapon.destroy
        redirect_to root_path
    end

    def destroy
        if @weapon.present?
          @weapon.destroy
          #redirect_to enemies_path
          render json: { message: "Weapon deleted successfully" }, status: :no_content
        else
          render json: { message: "Couldn't find Weapon" }, status: :not_found
        end
      end

    def show
        @weapon = set_weapon
    end

    def new
        @weapon = Weapon.new
    end

    private

    def weapon_params
        params.require(:weapon).permit(:name, :description, :power_base, :power_step, :level)
    end

    def set_weapon
        @weapon = Weapon.where(id: params[:id]).first
    end
end