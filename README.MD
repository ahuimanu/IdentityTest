# ASP.NET Core Identity

Quick tests of Authentication and Authorization

```
dotnet aspnet-codegenerator controller --model Domain.StudentOutcome --dataContext CIT.Data.SchoolContext --referenceScriptLibraries --useSqlite
```

## Git Basics

As I will create branches for each phase of the tutorial, I first review some git basics.

### Initialization

We need to initialize the repository so that git can track changes in a given folder (and its subfolders)

`git init`

### Cloning

You can clone a repo with this command:

`git clone /path/or/url/to/repository`

or

`git clone user@host:/path/to/repository`

### Add and Commit

You add files to be tracked by git, which means you do not have to mark all files for tracking.

You can also use a `.gitignore` file to specify explict files or patterns of files to be excluded from tracking.

#### Adding

If you want to add a specific file:

`git add <filename>`

IF you want to add some pattern:

`git add *.xml`

Or, just add it all

`git add -A`

#### Commits

Now that git is tracking changes in your files, you can periodically "save" these changes by commmiting them.

This is not the same thing as saving the file, it is saving the current state of the file(s) for the purposes of change tracking.  As sucn, git only tracks changes.

`git commit -m 'commit message`

#### Working with Remote Peers

Git doesn't use a central server architecture for version control, but many web-based services, such as Github, exist to provide a means of coordinating your local changes with a remote server.  This is one of the means by which more than one developer can share that codebase and work together through a shared remore repository.

The way that we establish a remote is with this command:

`git remote add origin <server_url>`

In this example, **origin** is the label/name you create to refer to the URL for the remote repository.

Now, when you want the remote repository to match the changes you've made locally, you issue this command:

`git push origin master`

Conversely, when you want the current state of the remote to be reflected in your local version, you issue this command:

`git pull origin master`

In this case, you are seeking to merge those changes into your local version and to be notified if there are conflicts.

#### Branching

Another strategy is to use branching to isolate a set of changes from the rest fo the repository.  This is useful for versioning and also for collaborators to avoid stepping on each other.

You can create a branch this way:

`git checkout -b name_of_branch`

You can see that **checkout** is the way to select a branch to "move" to and the **-b** option is the way to provide the name of the branch. If the branch doesn't exist it will be created.  Now, all changes you make to the codebase will be in that branch and not in the msater.

If you not longer need a branch, it can be deleted:

`git branch -d name_of_branch`

#### Merging

Eventually, it is common that you'll want to rejoin a branch to the main branch or otherwise merge one version into another.  Thie command to do so is:

`git merge <branch>`

The way this works is as follows:

You always are in a current branch and you can change in one of serveral ways:

`git status`

This will tell you quite a bit about the current state of your respository, but it will also tell you what branch is active.

It is also common for your git installation to modify the command interpreter/environment to show the name of the current branch as a part of the prompt.

So, the when you specify `git merge <branch>` you are saying "take the branch I name here and merge it INTO the current active branch."