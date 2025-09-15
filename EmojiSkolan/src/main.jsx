import { StrictMode } from 'react' // Makes it easier to find logical errors in the console. Not affecting build.
import { createRoot } from 'react-dom/client'
import { BrowserRouter as Router } from 'react-router-dom'
import App from './App.jsx'
import './index.css'
import './App.css'
import { AuthProvider } from './context/AuthContext.jsx'; 

createRoot(document.getElementById('root')).render(
  <StrictMode>
    <Router>
      <AuthProvider>
        <App />
      </AuthProvider>
    </Router>
  </StrictMode>
)