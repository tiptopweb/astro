#!/usr/bin/env sh

# abort on errors
set -e

# build
npm run build

# navigate into the build output directory
cd dist

# add .nojekyll to bypass GitHub Page’s default behavior
touch .nojekyll

# if you are deploying to a custom domain
echo 'astro.tiptopweb.com.au' > CNAME

git init
git add -A
git commit -m 'deploy'

# if you are deploying to https://<USERNAME>.github.io
# git push -f git@github.com:<USERNAME>/<USERNAME>.github.io.git main

git remote set-url origin git@github.com:tiptopweb/astro.git

# if you are deploying to https://<USERNAME>.github.io/<REPO>
git push -f git@github.com:tiptopweb/astro.git main:gh-pages

cd -