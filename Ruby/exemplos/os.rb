require 'os'

def myOS
    if OS.windows?
        systemName = "Windows"
    elsif OS.linux?
        systemName = "Linux"
    elsif OS.mac?
        systemName = "Mac"
    else
        systemName = "não identificado"
    end

    return systemName
end

def clearConsole
    if OS.windows?
        system("cls")
    elsif OS.linux?
        system("clear")
    end
end

clearConsole()
puts "-- Informações do sistema --
Processador: #{OS.cpu_count} cores
SO: #{myOS()} #{OS.bits} bits"
