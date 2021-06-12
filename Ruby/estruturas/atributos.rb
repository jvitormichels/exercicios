class Cachorro
    attr_accessor :nome, :idade
end

chorro = Cachorro.new
chorro.nome = 'Maicon'
chorro.idade = 12

puts "Ficha do chorro
Nome #{chorro.nome}
Idade: #{chorro.idade}"