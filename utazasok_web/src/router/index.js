import { createRouter, createWebHistory } from 'vue-router'
import HomeView from '../views/HomeView.vue'
import AboutUsView from "../views/AboutUsView.vue"

const router = createRouter({
  history: createWebHistory(import.meta.env.BASE_URL),
  routes: [
    {
      path: '/',
      name: 'home',
      component: HomeView
    },
    {
      path: '/aboutus',
      name: 'aboutus',
      component: AboutUsView
    },
    {
      path: '/foglalas',
      name: 'foglalas',
      component: () => import('../views/FoglalasView.vue')
    }
  ]
})

export default router
