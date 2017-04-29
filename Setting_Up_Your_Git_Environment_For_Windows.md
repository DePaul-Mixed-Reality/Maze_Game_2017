# Setting up your environment on windows

1. **First download git for windows**
2. Download **Sublime Text 3** text editor
3. Open the **Git Bash** program and run the command "ls" to list the files in your home directory
4. Download these files and put them in your "home" directory that you found by running the "ls" command in step 3:

[.bash_profile_course](https://www.udacity.com/api/nodes/3341718587/supplemental_media/bash-profile-course/download?_ga=1.37232743.672083044.1467344711)

#### **RENAME .bash_profile_course to .bash_profile**

[git-completion.bash](https://raw.githubusercontent.com/git/git/master/contrib/completion/git-completion.bash)

[git-prompt.sh](https://raw.githubusercontent.com/git/git/master/contrib/completion/git-prompt.sh)

4. Run these commands in Git Bash:

```
git config --global core.editor "'C:/Program Files/Sublime Text 3/sublime_text.exe' -n -w"
git config --global push.default upstream
git config --global merge.conflictstyle diff3
```

5. Restart **Git Bash**
6. If this did not work, please watch this video and it will show you step by step what you need to do: [video](https://www.youtube.com/watch?v=IfLhXM4RnB4)

