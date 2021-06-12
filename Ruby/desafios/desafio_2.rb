hashFoda = {}

3.times do 
    print "Insira sua chave: "
    chave = gets.chomp
    print "Insira o valor: "
    valor = gets.chomp
    hashFoda[chave] = valor
    puts ""
end

hashFoda.each do |chave, valor|
    puts "#{chave}: #{valor}"
end