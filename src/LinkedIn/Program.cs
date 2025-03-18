// Creating persons
using LinkedIn;

Person person1 = new Person("Ali Hosseini", "ali@gmail.com", "09123456789");
Person person2 = new Person("Maryam Rezaei", "maryam@gmail.com", "09129876543");
Person recruiterPerson = new Person("Hassan Mohammadi", "hasan@gmail.com", "09121234567");

// Creating profile for the first person
Profile profile1 = new Profile(
    "profile1.jpg",
    "cover1.jpg",
    "Male",
    "Tehran"
);
profile1.Experiences.Add("Programmer at Company X - 2021 to 2023");
profile1.Experiences.Add("Senior Expert at Company Y - 2023 to present");

// Creating member accounts
Member member1 = new Member(
    "user1",
    "pass123",
    person1,
    AccountStatus.Active,
    1
);

Member member2 = new Member(
    "user2",
    "pass456",
    person2,
    AccountStatus.Active,
    2
);

// Creating recruiter account
Recruiter recruiter = new Recruiter(
    "rec1",
    "pass789",
    recruiterPerson,
    AccountStatus.Active
);

// Sending friend request
FriendRequest friendRequest = new FriendRequest(member1, member2);
Console.WriteLine($"Friend request sent from {member1.Person.Name} to {member2.Person.Name}");
Console.WriteLine($"Request status: {friendRequest.Status}");

// Accepting friend request
friendRequest.Accept();
member1.Following.Add(member2);
member2.Followers.Add(member1);
Console.WriteLine("Friend request accepted");

// Creating and posting a post
Post post = new Post(member1, "post1", "Started a new project today!");
post.AddLike();
post.AddLike();
Console.WriteLine($"New post from {post.Owner.Person.Name}: {post.Text}");
Console.WriteLine($"Number of likes: {post.TotalLikes}");

// Sending message
Message message = new Message(
    "msg1",
    "Hi, how can I help with the project?",
    null,
    member2
);
member1.SendMessage(message.Text);
Console.WriteLine($"Message from {member1.Person.Name} to {message.SentTo.Person.Name}: {message.Text}");

// Creating and posting a job
Job job = new Job(
    "job1",
    "Hiring Senior C# Developer",
    "Novin Tech Company",
    DateTime.Now.AddDays(30)
);
recruiter.PostJob(job);
member1.PagesFollow.Add(job);
Console.WriteLine($"New job by {recruiter.Person.Name}: {job.Description}");

// Adding comment
Comment comment = new Comment(
    "cmt1",
    "Congrats! Wishing you success with the project",
    member2
);
comment.AddLike();
Console.WriteLine($"Comment from {comment.Owner.Person.Name}: {comment.Text} (Likes: {comment.TotalLikes})");