# Working With Git On The Project

### 1. Downloading the project

You can find the project by following [this link](https://github.com/DePaul-Mixed-Reality/Maze_Game_2017)

On the top right there is a green button that says "Clone of download"

You want to click that, and then click the copy to clipboard icon. You do not ever want to download the ZIP file. This is because that will not include the **git remotes** and **git commit history** that you will want to have access to.

After copying the link, go to **Git Bash** and run: 

```
git clone https://github.com/DePaul-Mixed-Reality/Maze_Game_2017.git
```

Cloning the project with give you access to the file history and will provide you with a default remote named **origin** that points to our git repository online

***

### 2. Staging Changes Checking Your Status

After you download the project, you will want to make changes. So you add some code. Now you are done adding code, and you want to upload your changes. Here is how:

In **Git Bash** go to the project folder and run:

```
git status
```

The **git status** command will show you all of the changes you made

After you see the changes you have made, you have to stage your changes. Staging your changed just means that you want to pick out specific files that you want to upload, rather than just adding all of your changes.

Stage files using the command:

```
git add path/to/my/file.extension
```

Now run **git status** and you should see your file in the staging area highlighted in green.

To add all your files to the staging area run:

```
git add .
```

Often you don't want to stage everything because your code might be incomplete, or unnecessary

***

### 3. Committing Your Changes

Once you have staged all of your files, you are going to want to commit them. Your commit will be an entry in the file history of our project. This is the command to commit:

```
git commit -m 'This is where you put the log message telling us what you changed'
```

***

### 4. Pushing Your Changes

Once you have committed your changes, no one will be able to see them until you put them online by pushing your code. **Before you push your code always pull the most recent code using this command**:

```
git pull
```

Once you have pulled the most recent code, you are ready to push your own code. Run this command in **Git Bash**:

```
git push origin master
```

Now your changes have been uploaded for everyone to see

***

## CONFLICTS

Sometimes when you pull new code, you will get conflicts. Git will automatically highlight the conflicts in the conflicted file for you to review. You will need to manually go into the file and update it with the best code, and test it to make sure it works.

After you update the file, you need to stage the changes, commit the fix, and push your code.

After this everything will be fine unless you did it wrong, then we will just have to revert the code which is fairly easy.

***

## What to do if you accidentally commit broken code

If you accidentally commit broken code you can undo your commit with the following command:

```
git reset HEAD~
```

This will undo the most recent commit without changing any of the code you committed. This means you can fix your mistakes and then re-stage and re-commit.

***

### You made some changes, but broke everything and want to restart from the most recent commit

If you want to restart the project from the most recent commit (eliminate all of your most recent changes) then run this command:

```
git reset --hard
```

This will delete your changes and resume the project at the most recent commit
