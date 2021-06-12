def potencia(base, expoente)
    return base ** expoente
end

print "Informe a base: "
base = gets.chomp.to_i
print "Informe o expoente: "
expoente = gets.chomp.to_i

puts "#{base}^#{expoente} = #{potencia(base, expoente)}"