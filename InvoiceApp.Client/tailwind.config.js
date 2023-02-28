/** @type {import('tailwindcss').Config} */
const colors = require('tailwindcss/colors')

module.exports = {
  content: [
    "./src/**/*.{html,ts}",
  ],
  theme: {
    extend: {
      colors: {
        danger: colors.rose,
        primary: {
          DEFAULT: '#1ABC9C',
          '50': '#f0faff',
          '100': '#e0f4fe',
          '200': '#baeafd',
          '300': '#7ddafc',
          '400': '#38c8f8',
          '500': '#14b9f1',
          '600': '#028fc7',
          '700': '#0372a1',
          '800': '#076085',
          '900': '#0c506e'
        },
        success: colors.green,
        warning: colors.yellow,
      },
    },
  },
  plugins: [],
}