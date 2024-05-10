import './Skeleton.css'

import React from 'react'

const Skeleton = () => {
  return (
    <div className='skeleton'>
        <div className="skeleton-header animate-pulse"></div>
        <div className="text animate-pulse"></div>
        <div className="footer animate-pulse"></div>
    </div>
  )
}

export default Skeleton