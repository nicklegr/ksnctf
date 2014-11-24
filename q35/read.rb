require 'sqlite3'
require 'pp'

db = SQLite3::Database.new("database.db")
db.execute('select * from user') do |row|
  pp row
end
