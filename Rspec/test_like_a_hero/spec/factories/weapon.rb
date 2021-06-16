FactoryBot.define do
  factory :weapon do
    name { FFaker::Lorem.word }
    description { FFaker::Lorem.phrase }
    power_base { FFaker::Random.rand(3..35) }
    power_step { FFaker::Random.rand(3..10) }
    level { FFaker::Random.rand(1..12) }
  end
end
