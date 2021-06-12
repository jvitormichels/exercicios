require 'nokogiri'
require 'net/http'


#puts "Deseja colher os posts de quantas páginas?"
#n = gets.chomp

#i = 1
#n.times do |i|
https = Net::HTTP.new('onebitcode.com', 443)
#para fazer o uso de chamadas https
https.use_ssl = true

response = https.get("/")

doc =   Nokogiri::HTML(response.body)

last_post = doc.at('h3 a')
puts last_post.content
puts last_post['href']