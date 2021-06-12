module Person
    class Pj
        def initialize name, cnpj
            @name = name
            @cnpj = cnpj
        end

        def add
            puts '-- Pessoa jurídica adicionada --'
            puts "Nome: #{@name}"
            puts "CNPJ: #{@cnpj}"
        end

        def check
            puts 'Tipo: Pessoa jurídica'
            puts "Nome: #{@name}"
            puts "CNPJ: #{@cnpj}"
        end
    end


    class Pf
        def initialize name, cpf
            @name = name
            @cpf = cpf
        end

        def add
            puts '-- Pessoa física adicionada --'
            puts "Nome: #{@name}"
            puts "CPF: #{@cpf}"
        end

        def check
            puts 'Tipo: Pessoa física'
            puts "Nome: #{@name}"
            puts "CPF: #{@cpf}"
        end
    end
end


def pausa
    puts
    print "Pressione enter para continuar"
    pause = gets.chomp
end


pessoas = []
loop do
    system("clear")
    puts "O que deseja fazer?"
    puts "1. Adicionar pessoa jurídica"
    puts "2. Adicionar pessoa física"
    puts "3. Listar pessoas"
    puts "4. Sair"
    escolha = gets.chomp
    system("clear")

    case escolha
    when '1'
        puts "-- Informe os dados --"
        print "Nome: "
        nome = gets.chomp
        print "CNPJ: "
        cnpj = gets.chomp
        
        system("clear")
        pj = Person::Pj.new(nome, cnpj)
        pj.add
        pessoas.push(pj)
        pausa

    when '2'
        puts "-- Informe os dados --"
        print "Nome: "
        nome = gets.chomp
        print "CPF: "
        cpf = gets.chomp
        
        system("clear")
        pf = Person::Pf.new(nome, cpf)
        pf.add
        pessoas.push(pf)
        pausa

    when '3'
        system("clear")
        pessoas.each do |pessoa|
            pessoa.check
            puts
        end
        pausa

    when '4'
        break

    end
end