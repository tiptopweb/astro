/* empty css                                                */import{r as c,c as l,a as n,t as u,b as d,F as i,o as v}from"./vendor.a3355b01.js";var p=(t,e)=>{const r=t.__vccOpts||t;for(const[o,s]of e)r[o]=s;return r};const f={setup(){const t=c(0);return{count:t,add:()=>t.value=t.value+1,subtract:()=>t.value=t.value-1}}},_={class:"counter"},m={class:"counter-message"};function b(t,e,r,o,s,k){return v(),l(i,null,[n("div",_,[n("button",{onClick:e[0]||(e[0]=a=>o.subtract())},"-"),n("pre",null,u(o.count),1),n("button",{onClick:e[1]||(e[1]=a=>o.add())},"+")]),n("div",m,[d(t.$slots,"default")])],64)}var B=p(f,[["render",b]]);export{B as default};
