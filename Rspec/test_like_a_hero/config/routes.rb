Rails.application.routes.draw do
  resources :enemies, only: [:index, :new, :create, :update, :destroy, :show]
  resources :users, only: [:index, :create]
  resources :weapons, only: [:index, :new, :create, :destroy, :show]
  root to: "weapons#index"
end
