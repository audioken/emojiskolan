import "./LoginPage.css";
import { useState, useEffect, useRef } from "react";
import Input from "../../components/UI/Input/Input";
import { useAuth } from "../../context/AuthContext";
import { useMultiForm } from "../../context/MultiFormContext";
import Button from "../../components/UI/Button/Button";

// LoginPage component handles user login form
const LoginPage = () => {
  const { login } = useAuth();

  // Ref and context for multi-form handling
  const formRef = useRef();
  const { setFormRef } = useMultiForm();

  // State for storing input values for identifier (username or email) and password
  const [formData, setFormData] = useState({
    identifier: "", // Can be either username or email
    password: "",
  });

  useEffect(() => {
    setFormRef("login", formRef);
  }, [setFormRef]);

  const [showPassword, setShowPassword] = useState(false);
  const [error, setError] = useState("");
  // Updates formData when user types in any input field
  const handleChange = (e) => {
    const { name, value } = e.target;
    setFormData((prev) => ({
      ...prev,
      [name]: value,
    }));
  };

  // Handles form submission when user clicks "Login"
  const handleSubmit = async (e) => {
    e.preventDefault(); // Prevents page reload

    try {
      await login(formData.identifier, formData.password); //  call context login
      window.location.href = "/"; // optional redirect after login
    } catch (err) {
      setError(err.message);
    }
  };

  // Render login form
  return (
    <div style={{ maxWidth: "400px", margin: "auto", padding: "1rem" }}>
      <h2>Logga in här</h2>
      {/* Login form with two input fields */}
      <form ref={formRef} onSubmit={handleSubmit}>
        {/* Identifier input (username or email) */}
        <Input
          label="Användarnamn eller E-post"
          type="text"
          name="identifier"
          value={formData.identifier}
          onChange={handleChange}
        />
        {/* Password input */}
        <div style={{ display: "flex", alignItems: "center" }}>
          <Input
            label="Lösenord"
            type={showPassword ? "text" : "password"}
            name="password"
            value={formData.password}
            onChange={handleChange}
          />
          <button
            type="button"
            onClick={() => setShowPassword((prev) => !prev)}
            style={{ marginLeft: "0.5rem", height: "2.5rem" }}
          >
            {showPassword ? "Dölj" : "Visa"}
          </button>
        </div>

        {/* Forgot password link under password field */}
        <div
          style={{
            display: "flex",
            justifyContent: "flex-end",
            marginTop: "0.5rem",
          }}
        >
          <Button
            label="Glömt lösenord?"
            path="/forgot-password"
            className="forgot-password-btn"
          />
        </div>

        {/* Invisible button to enable the form submission with the key "Enter" */}
        <button type="submit" className="invisible-btn" />
      </form>
    </div>
  );
};

export default LoginPage;
