import astroImagePlugin from "astro-imagetools/plugin";

export default {
  // projectRoot: '.',     // Where to resolve all URLs relative to. Useful if you have a monorepo project.
  // pages: './src/pages', // Path to Astro components, pages, and data
  //dist: '../api/Tiptopweb.Astro/wwwroot',       // Build to the ServiceStack wwwroot
  // public: './public',   // A folder of static files Astro will copy to the root. Useful for favicons, images, and other files that don’t need processing.
  buildOptions: {
    site: 'https://astro.tiptopweb.com.au',           // Your public domain, e.g.: https://my-site.dev/. Used to generate sitemaps and canonical URLs.
    sitemap: true,         // Generate sitemap (set to "false" to disable)
  },
  devOptions: {
    // hostname: 'localhost',  // The hostname to run the dev server on.
    // port: 3000,             // The port to run the dev server on.
  },
  vite: {
    plugins: [
      astroImagePlugin,
    ],
  },
  renderers: [
      '@astrojs/renderer-vue'
  ],
};
