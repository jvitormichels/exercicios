class Mart
    def initialize(products)
        @products = products
    end

    def listProducts
        @products.each_with_index do |product, index|
            puts "Code: #{index}"
            product.check()
            puts
        end
    end

    def buy(productCode)
        puts "#{@products[productCode].name} bought for $#{@products[productCode].price}"
    end
end