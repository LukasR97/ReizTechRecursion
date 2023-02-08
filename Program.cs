Branch branch = new Branch();
branch.branches = new List<Branch>();

Branch branchOne = new Branch();
Branch branchTwo = new Branch();
Branch branchThree = new Branch();
Branch branchFour = new Branch();
Branch branchFive = new Branch();

branch.branches.Add(branchOne);
branch.branches.Add(branchTwo);
branch.branches.Add(branchThree);
branch.branches.Add(branchFour);
branch.branches.Add(branchFive);

int answer = CalculateDepthOfStructure(branch);
Console.WriteLine($"The depth of structure is: {answer}");

static int CalculateDepthOfStructure(Branch branch,
    int depth = 0)
{
    //EXIT CONDITION
    if (branch.branches.Count == 0)
    {
        depth = 0;
        return depth;
    }

    if(branch.branches.Count != depth &&
        branch.branches.Count > depth) //little security for the optional paramater
    {
        return CalculateDepthOfStructure(branch, depth + 1);
    }

    if(branch.branches.Count < depth) //little security for the optional paramater
    {
        return CalculateDepthOfStructure(branch, depth - 1);
    }

    return depth;
}

public class Branch
{
    public List<Branch> branches;
}



