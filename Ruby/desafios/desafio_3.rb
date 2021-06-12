hashFoda = {A:10, B:30, c:20, D:35, E:15}

maiorValor = 0
maiorChave = 0
hashFoda.each do |chave, valor|
    if valor > maiorValor
        maiorValor = valor
        maiorChave = chave
    end
end

puts "#{maiorChave}: #{maiorValor}"