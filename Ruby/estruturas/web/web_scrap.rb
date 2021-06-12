def pausa
    puts
    print "Pressione enter para continuar"
    pause = gets.chomp
end

require 'nokogiri'
require 'net/http'

https = Net::HTTP.new('onebitcode.com', 443)
#para fazer o uso de chamadas https
https.use_ssl = true

responde = https.get("/")

doc =   Nokogiri::HTML(responde.body)

loop do
    system("clear")
    puts "Verificar \n1. Último post \n2. Todos os posts da primeira pag \n3. Sair"
    escolha = gets.chomp
    system("clear")

    case escolha
    when '1'
        last_post = doc.at('h3 a')
        puts last_post.content
        puts last_post['href']
        pausa
    when '2'
        doc.search('h3 a').each do |post|
            puts post.content
            puts post['href']
            puts
        end
        pausa
    when '3'
        break
    end
end