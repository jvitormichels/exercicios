class EnemiesController < ApplicationController
  before_action :set_enemy

  def index
    @enemies = Enemy.order(name: :asc)
  end

  def show
    @enemy = set_enemy
  end

  def new
    @enemy = Enemy.new
  end

  def create
    @enemy = Enemy.create(enemy_params)
    redirect_to enemies_path
  end

  def update
    if @enemy.present? 
      if @enemy.update(enemy_params)
        render json: @enemy, status: :ok
      else
        render json: { errors: @enemy.errors }, status: :unprocessable_entity
      end
    else
      render json: { message: "Couldn't find Enemy" }, status: :not_found
    end
  end

  def destroy
    if @enemy.present?
      @enemy.destroy
      #redirect_to enemies_path
      render json: { message: "Enemy deleted successfully" }, status: :no_content
    else
      render json: { message: "Couldn't find Enemy" }, status: :not_found
    end
  end


  private

  def enemy_params
    params.require(:enemy).permit(:name, :power_base, :power_step, :level, :kind)
  end

  def set_enemy
    @enemy = Enemy.where(id: params[:id]).first
  rescue ActiveRecord::RecordNotFound => e
    render json: { message: e.message }, status: :not_found
  end
end