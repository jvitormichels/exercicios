require 'uri'
require 'net/http'
require 'openssl'

url = URI("https://google-translate1.p.rapidapi.com/language/translate/v2")

http = Net::HTTP.new(url.host, url.port)
http.use_ssl = true
http.verify_mode = OpenSSL::SSL::VERIFY_NONE

request = Net::HTTP::Post.new(url)
request["content-type"] = 'application/x-www-form-urlencoded'
request["accept-encoding"] = 'application/gzip'
request["x-rapidapi-key"] = '518d1c192bmshb5188d0bb95dc06p13d4f0jsn178225c6d96c'
request["x-rapidapi-host"] = 'google-translate1.p.rapidapi.com'
request.body = "q=Hello%2C%20world!&target=es&source=en"

response = http.request(request)
puts response.read_body