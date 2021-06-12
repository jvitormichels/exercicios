loop do
    print "Escolha a operação: \n1.Soma \n2.Subtração \n3.Multiplicação \n4.Divisão \n5.Sair\n"
    escolha = gets.chomp
    system("clear")
    break if escolha == '5'

    print "Primeiro número: "
    n1 = gets.chomp.to_i
    print "Segundo número: "
    n2 = gets.chomp.to_i

    case escolha
    when '1'
        resultado = n1 + n2
    when '2'
        resultado = n1 - n2
    when '3'
        resultado = n1 * n2
    when '4'
        resultado = n1 / n2
    else
        resultado = "Operação inválida"
    end


    puts "Resultado: #{resultado}\n"
    puts "Deseja calcular novamente? (s/n)"
    repete = gets.chomp
    system("clear")

    if repete == 'n'
        break
    end
end