require 'rails_helper'

RSpec.describe Weapon, type: :model do

  it 'returns the correct title' do
    name = FFaker::Lorem.word
    level = FFaker::Random.rand(1..12)
    weapon = build(:weapon, name: name, level: level)
    expect(weapon.title).to eq("#{name} ##{level}")
  end

  it 'has the right power' do
    power_base = FFaker::Random.rand(1..12)
    power_step = FFaker::Random.rand(1..12)
    level = FFaker::Random.rand(1..12)
    weapon = build(:weapon, power_base: power_base, power_step: power_step, level: level)

    weaponPower = (power_base + ((level - 1) * power_step))
    expect(weapon.current_power).to eq weaponPower
  end

end
