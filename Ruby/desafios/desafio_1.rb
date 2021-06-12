numeros = []

3.times do 
    print "Informe um número: "
    n = gets.chomp.to_i
    numeros.push(n)
end

potencia = numeros.map do |numero|
    numero * 2
end

puts "Vetor original: \n#{numeros}"
puts "Elevados ao quadrado: \n#{potencia}"