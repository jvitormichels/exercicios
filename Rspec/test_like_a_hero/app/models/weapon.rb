class Weapon < ApplicationRecord
    validates :name, presence: true

    def title
        "#{self.name} ##{self.level}"
    end

    def current_power
        (power_base + ((level - 1) * power_step))
    end
end
