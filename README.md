# TestSemanticRelease
Test to see the benefits of using semantic release 
It will follow semantic versioning with the format of v{Major}{Minor}{Patch} e.g. v1.2.3
- {Patch} → backward compatible bug fixes
- {Minor} → new backward compatible features, deprecation of public api
- {Major} → new backward incompatible api
- {Major} = 0 → Initial development when anything can change
- {Major} >= 1 → 1st public stable release

## Adding a commit 
Commits are added in Agular format and must be one  of the following in order to create a release: 
- **feat**: A new feature
- **fix**: A bug fix
- **docs**: Documentation only changes
- **style**: Changes that do not affect the meaning of the code (white-space, formatting, missing semi -colons, etc)
- **refactor**: A code change that neither fixes a bug or adds a feature
- **perf**: A code change that improves performance
- **test**: Add missing or correcting existing test
- **build**: Changes that affect the build system or external dependencies (example scopes: gulp, broccoli, npm)
- **ci**: Changes to our CI Configuration files and scripts (example scopes: Travis, Circle, BrowserStack, SauceLabs)
- **revert**: Reverts a previous commit
- **chore**: Changes the build process or auxiliary tools and libraries such as documentation


### Suggestions for other documentation to read 
- [Semantic-release Gitbook](https://semantic-release.gitbook.io/semantic-release/usage/getting-started )
- [Basic Guide to Semantic Release](https://levelup.gitconnected.com/basic-guide-to-semantic-release-9e2aa7834e4b)
- [Semantic Release changlog plugin](https://github.com/semantic-release/changelog)
- [Video - Fully Automated npm publish using Github Actions and Semantic Release](https://www.youtube.com/watch?v=QZdY4XYbqLI)
- [commitize/cz/cli](https://github.com/commitizen/cz-cli)
