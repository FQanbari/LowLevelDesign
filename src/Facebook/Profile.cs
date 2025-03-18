using System;

namespace Facebook;

public class Profile
{
    public string ProfilePic { get; set; }
    public string CoverPic { get; set; }
    public string Gender { get; set; }
    public List<string> Experiences { get; set; } = new List<string>();
    public string Place { get; set; }

    public Profile(string profilePic, string coverPic, string gender, string place)
    {
        ProfilePic = profilePic;
        CoverPic = coverPic;
        Gender = gender;
        Place = place;
    }
}
