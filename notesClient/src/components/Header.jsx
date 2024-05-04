import React from 'react'
import { MdNightsStay, MdWbSunny } from "react-icons/md"

const Header = ({ darkMode, handleToggleDarkMode }) => {
    return (
        <div className='header'>
            <h1>Notes</h1>
            <button
                onClick={() =>
                    handleToggleDarkMode((curr) => !curr)}
                className='btn'>
                {darkMode ? (
            <MdWbSunny />
          ) : (
            <MdNightsStay />
          )}
            </button>
        </div>
    )
}

export default Header