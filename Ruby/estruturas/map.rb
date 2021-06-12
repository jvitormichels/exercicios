firstArray = [0, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10]

#atribui firstArray modificado a secondArray
secondArray = firstArray.map do |n|
    n * 2
end

puts "#{firstArray}"
puts "#{secondArray}"

#sobrescreve firstArray (observe que se utiliza map! aqui)
firstArray.map! do |n|
    n / 2
end

puts "#{firstArray}"