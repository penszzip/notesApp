import './Skeleton.css'

import React from 'react'

const Skeleton = () => {
  return (
    <div className='skeleton animate-pulse'>
        <div className="text"></div>
        <div className="footer"></div>
    </div>
  )
}

export default Skeleton