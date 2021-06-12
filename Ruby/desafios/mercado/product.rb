class Product
    attr_accessor :name, :price
    
    def initialize(name, price)
        @name = name
        @price = price
    end

    def check
        puts "Product: #{@name} \nPrice: $#{@price}"
    end
end