class Person
    def initialize(name, age)
        @name = name
        @age = age
    end

    def check
        puts "Ficha maneira"
        puts "Nome: #{@name}"
        puts "Idade: #{@age}"
    end
end

pessoa = Person.new('Maicão', 14)
pessoa.check()