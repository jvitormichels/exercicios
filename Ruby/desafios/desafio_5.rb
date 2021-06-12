require 'cpf_cnpj'

loop do
    print "Informe seu CPF: "
    cpf = gets.chomp

    if CPF.valid?(cpf) 
        puts "CPF válido!"
        break
    else
        puts "CPF inválido!"
    end
end