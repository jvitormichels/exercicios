firstArray = [0, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10]

selection = firstArray.select do |n|
    n >= 4  && n <= 7
end

puts "#{selection}"


operacao = {1=>'Soma', 2=>'Subtração', 3=>'Multiplcação'}

selection = operacao.select do |codigo|
    codigo < 3
end

puts "#{selection.values}"