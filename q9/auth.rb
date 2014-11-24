require 'net/http'
require 'uri'
require 'pp'
require 'open-uri'
require 'digest/md5'
require 'pry'
require 'pry-nav'

@http = Net::HTTP.new('ctfq.sweetduet.info', 10080)
path = '/~q9/flag.html'

req = Net::HTTP::Get.new(path)
response = @http.request(req)

response.each do |k, v|
  puts "#{k}, #{v}"
end

response['www-authenticate'][/nonce="(.+?)"/]
nonce = $1
puts nonce

cnonce = "9691c249745d94fc"

# q9:secret:c627e19450db746b739f41b64097d449

# A1 = ユーザ名 ":" realm ":" パスワード
# A2 = HTTPのメソッド ":" コンテンツのURI
# response = MD5( MD5(A1) ":" nonce ":" nc ":" cnonce ":" qop ":" MD5(A2) )

md5_A1 = "c627e19450db746b739f41b64097d449"
puts md5_A1

md5_A2 = Digest::MD5.hexdigest("GET:#{path}")
puts md5_A2

nc = '00000001'

response = "#{md5_A1}:#{nonce}:#{nc}:#{cnonce}:auth:#{md5_A2}"
puts response

response_hash = Digest::MD5.hexdigest(response)
puts response_hash

puts "----------"

req = Net::HTTP::Get.new(path)
req['Host'] = "ctfq.sweetduet.info:10080"
req['Authorization'] = <<"EOD"
Digest username="q9", realm="secret", nonce="#{nonce}", uri="#{path}", algorithm=MD5, response="#{response_hash}", qop=auth, nc=#{nc}, cnonce="#{cnonce}"
EOD

req.each do |k, v|
  puts "#{k}, #{v}"
end

response = @http.request(req)
puts response.body
