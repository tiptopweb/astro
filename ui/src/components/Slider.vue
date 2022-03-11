<template>
  <Splide :options="{ rewind: true, perPage: 2, gap: '1rem' }">
    <SplideSlide v-for="slide in slides" :key="slide.alt">
      <img :src="slide.src" :alt="slide.alt">
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
    }
  }
})
</script>