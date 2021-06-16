FactoryBot.define do
  factory :enemy do
    name { FFaker::Lorem.word }
    power_base { FFaker::Random.rand(1..40) }
    power_step { FFaker::Random.rand(1..20) }
    level { FFaker::Random.rand(1..40) }
    kind { %w[goblin orc demon dragon].sample }
  end
end
