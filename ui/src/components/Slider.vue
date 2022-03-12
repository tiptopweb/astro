<template>
  <Splide :options="options">
    <SplideSlide v-for="slide in slides" :key="slide.alt">
      <img :data-splide-lazy="slide.src" :width="slide.width" :height="slide.height" :alt="slide.alt">
    </SplideSlide>
  </Splide>
</template>

<script lang="ts">
import { Splide, SplideSlide } from '@splidejs/vue-splide';
import { defineComponent } from 'vue';
import '@splidejs/splide/dist/css/themes/splide-default.min.css';

export default defineComponent({
  name: 'Slider',
  
  components: {
    Splide, 
    SplideSlide
  },
  
  props: {
    slides: Array
  },
  
  setup() {
    return {
      options: {
        type: 'loop',
        pagination: false,
        arrows: 'slider',
        lazyLoad: 'nearby',
        perPage: 2,
        gap: 10,
        breakpoints: {
          640: {
            perPage: 1,
          }
        }
      }
    }
  }
})
</script>

<style>
  .splide__arrow--prev {
    left: -1.6em;
  }
  .splide__arrow--next {
    right: -1.6em;
  }
</style>