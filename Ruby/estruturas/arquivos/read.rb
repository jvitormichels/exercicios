def addFruit fruit
    puts "--- Lista de compras ---"
    file = File.open('shoppingList.txt', 'a')

    File.open('shoppingList.txt', 'a') do |line|
        line.puts fruit
    end
end

def listFruits
    puts "--- Lista de compras ---"
    file = File.open('shoppingList.txt')

    file.each do |line|
        print line
    end
end

def pausa
    puts
    print "Pressione enter para continuar"
    pause = gets.chomp
end


loop do
    puts "O que deseja fazer?
    1. Adicionar fruta
    2. Listar frutas
    3. Sair"

    escolha = gets.chomp
    case escolha
    when '1'
        system("clear")
        print "Nome da fruta: "
        fruta = gets.chomp
        addFruit(fruta)
        system("clear")
    when '2'
        system("clear")
        listFruits
        pausa
    when '3'
        system("clear")
        break
    end
end