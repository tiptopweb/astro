# Astro + ServiceStack

Following the ideas from ServiceStack's <https://jamstacks.net/> (C# Jamstack Projects).

We have 2 projects: an Astro project in `/ui` and a ServiceStack C# project in `/api`.

We use Astro to generate Static assets and write them to the `/api/wwwroot` of the C# project during the Astro npm publish.

We use the C# project to answer API calls during the npm build and at run-time. 
During the build Astro is fetching data from the API (so the C# project needs to be published at least once before the Astro build).

The C# project is using ServiceStack AutoQuery to provide data out of a SqlLite `Chinook` database (see here: <https://github.com/NetCoreApps/Chinook>).
We are fetching a list of Artists and Albums.
Astro is generating at build time the list of Artists and building dynamically one page per artist!

Demo: <https://astro.tiptopweb.com.au/>

TODO:

* Also add some API calls at run time and test partial hydration
* publish the static part to CDN and proxy the /api to the web server
* add TailwindCSS and Vue components
