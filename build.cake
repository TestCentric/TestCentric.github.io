#addin nuget:?package=Cake.Git&version=0.22.0

using Path = System.IO.Path;

var target = Argument("target", "Default");

const string WYAM = "wyam";
//var PROJECT_DIR = Context.Environment.WorkingDirectory.FullPath + "/";
var OUTPUT_DIR = Path.GetFullPath("docs/");
var DEPLOY_DIR = Path.GetFullPath("../testcentric.github.io.deploy/");

var PROJECT_URI = "https://github.com/TestCentric/testcentric.github.io";
var PREVIEW_URI = "http://localhost#5080";

const string USER_ID = "USER_ID";
const string USER_EMAIL = "USER_EMAIL";
const string GITHUB_PASSWORD = "GITHUB_PASSWORD";

string UserId;
string UserEmail;
string GitHubPassword;

Setup((context) =>
{
    UserId = context.EnvironmentVariable(USER_ID);
    UserEmail = context.EnvironmentVariable(USER_EMAIL);
    GitHubPassword = context.EnvironmentVariable(GITHUB_PASSWORD);
});

Task("Build")
    .Does(() => StartProcess(WYAM, $"build -o {OUTPUT_DIR}"));

Task("Preview")
    .IsDependentOn("Build")
    .Does(() => StartProcess(WYAM, $"preview {OUTPUT_DIR}"));

Task("Deploy")
    .IsDependentOn("Build")
    .Does(() => 
    {
        if(FileExists("./CNAME"))
            CopyFile("./CNAME", $"{OUTPUT_DIR}CNAME");

        EnsureDirectoryExists(DEPLOY_DIR); // Temporary

        DeleteDirectory(DEPLOY_DIR, new DeleteDirectorySettings {
            Recursive = true,
            Force = true
        });

        GitClone(PROJECT_URI, DEPLOY_DIR, new GitCloneSettings()
        {
            Checkout = true,
            BranchName = "master"
        });

        //CopyDirectory(OUTPUT_DIR, DEPLOY_DIR);

        // GitAddAll(DEPLOY_DIR);
        // GitCommit(DEPLOY_DIR, UserId, UserEmail, "Deploy site to GitHub Pages");
        // GitPush(DEPLOY_DIR, UserId, GitHubPassword);

        // GitAddAll("./");
        // GitCommit("./", UserId, UserEmail, "Deploy site to GitHub Pages");
        // GitPush("./", UserId, GitHubPassword);
    });

Task("Default")
    .IsDependentOn("Build");
    
RunTarget(target);
