module.exports = {
    content: [
        './public/**/*.html',
        './src/**/*.{astro,js,jsx,svelte,ts,tsx,vue}',
    ],

    // more options here

    theme: {
        extend: {
            screens: {
                'sm': '480px',
                // => @media (min-width: 480px) { ... }
            },
        },
    },
};