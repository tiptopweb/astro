import{d as _,S as m,a as u,r as p,c as i,w as l,o as r,b as f,e as h,F as S,f as g}from"./vendor.bd2f3faf.js";/* empty css                                               */var k=(e,a)=>{const o=e.__vccOpts||e;for(const[s,n]of a)o[s]=n;return o};const w=_({name:"Slider",components:{Splide:m,SplideSlide:u},props:{slides:Array},setup(){return{options:{type:"loop",pagination:!1,arrows:"slider",perPage:2,gap:10,breakpoints:{640:{perPage:1}}}}}}),v=["src","width","height","alt"];function y(e,a,o,s,n,B){const c=p("SplideSlide"),d=p("Splide");return r(),i(d,{options:e.options},{default:l(()=>[(r(!0),f(S,null,h(e.slides,t=>(r(),i(c,{key:t.alt},{default:l(()=>[g("img",{src:t.src,width:t.width,height:t.height,alt:t.alt},null,8,v)]),_:2},1024))),128))]),_:1},8,["options"])}var b=k(w,[["render",y]]);export{b as default};
