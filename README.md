# How to update the development branch

0. Apply changes on master:

   1. Update src/*.pug + CSS files

   2. Run `dotnet fsi fixup.fsx`

   3. Run `build.bat` to generate output into `public`

   4. Run `dotnet fsi fixup.fsx` in `public`

   5. Commit changes (but review first!)

1. `git cherry-pick <commit-hash-to-apply>` - use the commit from master you want to apply, or a hash..hash pair for a range of commits.

2. Resolve conflicts, if any. Use VS Code to help with diffs and staging changes.

3. `git push` to push out your resolved changes.

4.  If the `merged` tag does not exist yet, create it:

    `git tag merged` on *master*

    otherwise, delete it and move tag to latest commit:

    `git tag -d merged`
    `git push --delete origin merged`
    `git tag merged`

5. `git push origin merged` on *master*

