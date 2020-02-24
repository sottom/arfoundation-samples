# Git Strategy

<!-- TOC -->

- [Git Strategy](#git-strategy)
    - [Getting Started](#getting-started)
    - [Our Strategy](#our-strategy)
        - [Creating a Branch](#creating-a-branch)
        - [Changing and Pushing your Code](#changing-and-pushing-your-code)
        - [Making sure you have the most recent changes](#making-sure-you-have-the-most-recent-changes)
        - [Merging into Master](#merging-into-master)
    - [Daily Pattern](#daily-pattern)
        - [Waiting for Pull Request to be Merged?](#waiting-for-pull-request-to-be-merged)

<!-- /TOC -->

## Getting Started

```bash
git clone https://github.com/sottom/arfoundation-samples.git
cd arfoundation-samples
```

After importing the project, `Add`it to Unity Hub and open it.

## Our Strategy

### Creating a Branch

You won't be able to push to `master` because it's disabled. You will need to do the following:

Create your own branch - `git checkout -b {your_branch_name}` (use your initials somewhere in the name)

- Example - `git checkout -b ms-occlusion`

### Changing and Pushing your Code

Make changes and push your code

```bash
git add -A
git commit -m 'short message about what you changed'
git push -u origin {your_branch_name}
```

Adding `-u` in the `push` statement allows you to track the remote (Github) branch with your local branch. After doing this the first time, you can just run `git push` to get your changes to github.

### Making sure you have the most recent changes

When you are ready to merge your code into master, rebase to make sure you have the most recent updates to master, then force push.

```bash
(from your branch)
git fetch
git rebase origin/master
git push -f
```

### Merging into Master

Create a pull request. Make sure you are pointing your branch to `sottom/arfoundation-samples`. You do not want to push to the `Unity-Technologies` repository. Someone will have to review your changes before the pull request is merged into master.

## Daily Pattern

1. Pull master before you start working

   ```bash
   (from your branch)
   git fetch
   git rebase origin/master
   ```

2. Commit code often

   ```bash
   git add -A
   git commit -m 'short message about what you changed'
   git push
   ```

3. Make pull requests often so there isn't much to review

### Waiting for Pull Request to be Merged?

1. Create a new branch off of master while you wait

2. When your Pull Request is merged, rebase onto your new branch

   ```bash
   (from your branch)
   git fetch
   git rebase origin/master
   ```

