# Astro + ServiceStack

Following the ideas from ServiceStack's <https://jamstacks.net/> (C# Jamstack Projects).

We have 2 projects: an Astro project in `/ui` and a ServiceStack C# project in `/api`.

We use Astro to generate Static assets and write them to the `/api/wwwroot` of the C# project during the Astro npm publish.

We use the C# project to answer API calls during the npm build and at run-time. 
During the build Astro is fetching data from the API (so the C# project needs to be published at least once before the Astro build).

The C# project is using ServiceStack AutoQuery to fetch data out of a MS SQL database (from an existing website <https://www.affrenchfilmfestival.org/films/sydney>).
We are fetching a list of Films and associated images.
Astro is generating at build time the list of Films and building dynamically one page per film!

The C# .NET 6 project is published in a Linux AMI 2 instance on AWS.

Testing Splide slider as Vue component
<https://splidejs.com/integration/vue-splide/>

Demo: <https://astro.tiptopweb.com.au/>

TODO:

* Also add some API calls at run time and test partial hydration (registration form)
* publish the static part to CDN (Github page or S3 bucket) and proxy the /api to the web server
