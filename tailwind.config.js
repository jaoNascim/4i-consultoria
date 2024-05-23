/** @type {import('tailwindcss').Config} */
module.exports = {
  darkMode: 'class',
  content: ["./**/*.{razor,html,cshtml}"],
  theme: {
    fontFamily: {
      body: ['Nunito']
      // general: ['"general"', "Arial", "Helvetiva", "sans-serif"],
      // melodrama: 'Melodrama, Arial, Helvetiva, sans-serif',
    },
    extend: {
      keyframes: {
        'slide-left': {
          from: { transform: 'translateX(0)' },
          to: { transform: 'translateX(-100%)' },
        },
      },
      animation: {
        'slide-left': 'slide-left 30s linear infinite',
      },
      backgroundImage: {
        '01': "url(../Images/Rectangle.png)",
        '02': "url(../Images/BlueBG.png)"
      },
      colors: {
        'custom-gray': '#191815',
        'custom-light-gray': '#403d37'
      }
    },
  },
  plugins: [],
}