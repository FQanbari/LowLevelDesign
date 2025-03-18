using Facebook;

var address = new Address("street", "city", "state", "zipcode", "country");
var person1 = new Person("John", "john@example.com", "1234567890", address);
var person2 = new Person("Jane", "jane@example.com", "0987654321", address);
var member1 = new Member("user1", "pass123", person1, AccountStatus.Active, 1);
var member2 = new Member("user2", "pass456", person2, AccountStatus.Active, 2);

var request = member1.SendRequest(member2);
request.Accept();
Console.WriteLine($"Following count: {member1.Following.Count}"); // خروجی: 1
Console.WriteLine($"Followers count: {member2.Followers.Count}"); // خروجی: 1