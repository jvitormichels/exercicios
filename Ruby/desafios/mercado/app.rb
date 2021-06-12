require_relative 'mart'
require_relative 'product'

products = []
products.push(Product.new('Sponge', 5.90))
products.push(Product.new('Shirt', 45.00))
products.push(Product.new('Soda', 9.00))
products.push(Product.new('Doritos', 6.40))
products.push(Product.new('Pizza', 20.00))
products.push(Product.new('Beer', 3.50))
walmart = Mart.new(products)

loop do
    system("clear")
    walmart.listProducts()
    print "Code for buy: "
    productCode = gets.chomp.to_i
    system("clear")
    walmart.buy(productCode)

    puts "\nAnything more? (y/n)"
    answer = gets.chomp
    if answer == 'n'
        system("clear")
        puts "\nThanks for the preference!"
        break
    end
end