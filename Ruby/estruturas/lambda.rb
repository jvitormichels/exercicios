def executeLambdas(testLambda, testProc)
    numbers = [10]
    testProc.call(numbers)
    numbers = [1]
    puts testLambda.call(numbers)
end

testLambda = lambda do |numbers|
    numbers.each do |number|
        return "#{number} * 2 = #{number * 2}"
    end
end

testProc = Proc.new do |numbers|
    numbers.each do |number|
        puts "#{number}² = #{number ** 2}"
    end
end

puts "Calling the lambda directly"
numbers = [1]
puts testLambda.call(numbers)
puts

puts "Calling the proc directly"
numbers = [3]
puts testProc.call(numbers)
puts

puts "Sending a lambda and a proc as parameters to a function and calling it inside it"
executeLambdas(testLambda, testProc)
puts

puts testLambda.class.name
puts testProc.class.name