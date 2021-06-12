#recebendo apenas o bloco
def teste
    #yield executa o bloco de código que foi recebido como parâmetro
    yield
    puts 'hehe'
    yield
end

#passando o bloco de código como parâmetro
teste do
    puts 'boi'
end
puts
#-----------------
#recebendo um parâmetro além do bloco
def teste2 (name, &block)
    @name = name

    if block_given?
        block.call
    else
        puts "sem bloco passado"
    end
end

teste2("Jorgin")
teste2("Jorgin") {puts "eai #{@name}"}
puts
#---------------------

def teste3(numbers, &block)
    if block_given?
        numbers.each do |key, value|
            block.call(key, value)
        end
    end
end

numbers = {1 => 10, 2 => 20, 3 => 30}

teste3(numbers) do |key, value|
    puts "#{key} * #{value} = #{key * value}"
    puts "#{key} + #{value} = #{key + value}"
    puts "---"
end