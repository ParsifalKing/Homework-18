using Domain.Models;
namespace Infrasturture.Services;


public class GroupService
{
    public List<Group> groups = new List<Group>();

    public void CreateGroup(Group group)
    {
        groups.Add(group);
    }
    public List<Group> GetGroup()
    {
        return groups;
    }
    public void UpdateGroup(Group group)
    {
        var gr = groups.FirstOrDefault(e => e.Id == group.Id);
        gr.Name = group.Name;
        gr.Description = group.Description;
    }
    public string DeleteGroup(int id)
    {
        var group = groups.FirstOrDefault(e => e.Id == id);
        groups.Remove(group);
        return $"Group deleted succesfully";
    }

}
