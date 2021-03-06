using System;
using System.IO;

using Microsoft.SPOT;

namespace schemas.example.org.AttachmentService
{
    class HelpIcon : IDisposable
    {

        private MemoryStream m_memoryStream = null;

        public HelpIcon ()
        {
            m_memoryStream = new MemoryStream(m_imageBuffer);
        }

        public MemoryStream Data { get { return m_memoryStream; } set { m_memoryStream = value; } }

        protected virtual void Dispose(bool disposing)
        {
            if (disposing)
            {
                // dispose managed resources
                if (m_memoryStream != null)
                {
                    m_memoryStream.Dispose();
                    m_memoryStream = null;
                }
            }
            // free native resources
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }

        private byte[] m_imageBuffer = {
            0x0,0x0,0x1,0x0,0x3,0x0,0x20,0x20,0x10,0x0,0x0,0x0,0x0,0x0,0xE8,0x2,0x0,0x0,0x36,0x0,
            0x0,0x0,0x10,0x10,0x10,0x0,0x0,0x0,0x0,0x0,0x28,0x1,0x0,0x0,0x1E,0x3,0x0,0x0,0x30,0x30,
            0x0,0x0,0x0,0x0,0x0,0x0,0xA8,0xE,0x0,0x0,0x46,0x4,0x0,0x0,0x28,0x0,0x0,0x0,0x20,0x0,
            0x0,0x0,0x40,0x0,0x0,0x0,0x1,0x0,0x4,0x0,0x0,0x0,0x0,0x0,0x80,0x2,0x0,0x0,0x0,0x0,
            0x0,0x0,0x0,0x0,0x0,0x0,0x0,0x0,0x0,0x0,0x0,0x0,0x0,0x0,0x0,0x0,0x0,0x0,0x0,0x0,
            0x80,0x0,0x0,0x80,0x0,0x0,0x0,0x80,0x80,0x0,0x80,0x0,0x0,0x0,0x80,0x0,0x80,0x0,0x80,0x80,
            0x0,0x0,0x80,0x80,0x80,0x0,0xC0,0xC0,0xC0,0x0,0x0,0x0,0xFF,0x0,0x0,0xFF,0x0,0x0,0x0,0xFF,
            0xFF,0x0,0xFF,0x0,0x0,0x0,0xFF,0x0,0xFF,0x0,0xFF,0xFF,0x0,0x0,0xFF,0xFF,0xFF,0x0,0x0,0x0,
            0x0,0x0,0x0,0x0,0x0,0x0,0x0,0x0,0x0,0x0,0x0,0x0,0x0,0x0,0x0,0x0,0x0,0x0,0x0,0x0,
            0x0,0x0,0x0,0x0,0x0,0x0,0x0,0x0,0x0,0x0,0x0,0x0,0x0,0x0,0x0,0x0,0x0,0x0,0x0,0x0,
            0x0,0x0,0x0,0x0,0x0,0x0,0x0,0x0,0x7,0x0,0x0,0x0,0x0,0x0,0x0,0x0,0x0,0x0,0x0,0x0,
            0x0,0x0,0x0,0x0,0x7,0xFF,0xFF,0xFF,0xFF,0xFF,0xFF,0x0,0x0,0x0,0x0,0x0,0x0,0x0,0x0,0x0,
            0x7,0xFF,0xFF,0xFF,0xFF,0xFF,0xFF,0x0,0x0,0x0,0x0,0x0,0x0,0x0,0x0,0x0,0x7,0xFF,0xFF,0xFF,
            0xFF,0xFF,0xFF,0x0,0x0,0x0,0x0,0x0,0x0,0x0,0x0,0x0,0x7,0xFF,0x77,0x77,0x77,0x77,0xFF,0x0,
            0x0,0x0,0x0,0x0,0x0,0x0,0x0,0x0,0x7,0xFF,0xFF,0xFF,0xFF,0xFF,0x0,0x0,0x0,0x0,0x0,0x0,
            0x0,0x0,0x0,0x0,0x7,0xFF,0x77,0x77,0x77,0x78,0xB,0xBB,0xBB,0x0,0x0,0x0,0x0,0x0,0x0,0x0,
            0x7,0xFF,0xFF,0xFF,0xFF,0xFF,0xB,0xBB,0xBB,0x0,0x0,0x0,0x0,0x0,0x0,0x0,0x7,0xFF,0x77,0x77,
            0x77,0x78,0xB,0xBB,0xBB,0x0,0x0,0x0,0x0,0x0,0x0,0x0,0x7,0xFF,0xFF,0xFF,0xFF,0xFF,0xB,0xBB,
            0xBB,0x0,0x0,0x0,0x0,0x0,0x0,0x0,0x7,0xFF,0x77,0x77,0x77,0x78,0x0,0x0,0x0,0x0,0x0,0x0,
            0x0,0x0,0x0,0x0,0x7,0xFF,0xFF,0xFF,0xFF,0xFF,0xFF,0x0,0x0,0x0,0x0,0x0,0x0,0x0,0x0,0x0,
            0x7,0xFF,0x77,0x77,0x77,0x78,0x0,0x0,0x0,0x0,0x0,0x0,0x0,0x0,0x0,0x0,0x7,0xFF,0xFF,0xFF,
            0xFF,0xFF,0xB,0xBB,0xBF,0x0,0x0,0x0,0x0,0x0,0x0,0x0,0x7,0xFF,0xFF,0xFF,0xFF,0xF8,0xB,0xBB,
            0xBB,0xF0,0x0,0x0,0x0,0x0,0x0,0x0,0x7,0xFF,0xFF,0xFF,0xFF,0xF8,0xB,0xBB,0xBB,0xB7,0x80,0x0,
            0x0,0x0,0x0,0x0,0x7,0xFF,0xFF,0xFF,0xFF,0xF8,0xF0,0xBB,0xBB,0xBB,0x70,0x0,0x0,0x0,0x0,0x0,
            0x7,0x77,0x77,0x77,0x77,0x77,0x70,0x80,0xBB,0xBB,0xB8,0x70,0x0,0x0,0x0,0x0,0x0,0x0,0x0,0x0,
            0x0,0x0,0x0,0x0,0xB,0xBB,0xBB,0x0,0x0,0x0,0x0,0x0,0x0,0x0,0x0,0x0,0x0,0x0,0x0,0x0,
            0x0,0xBB,0xBB,0x0,0x0,0x0,0x0,0x0,0x0,0x0,0x0,0x0,0xB,0xBB,0xB0,0x0,0x0,0xBB,0xBB,0x0,
            0x0,0x0,0x0,0x0,0x0,0x0,0x0,0x0,0xB,0xBB,0xB0,0x0,0x0,0xBB,0xBB,0x0,0x0,0x0,0x0,0x0,
            0x0,0x0,0x0,0x0,0xB,0xBB,0xBB,0x0,0xB,0xBB,0xBB,0x0,0x0,0x0,0x0,0x0,0x0,0x0,0x0,0x0,
            0x80,0xBB,0xBB,0xBB,0xBB,0xBB,0xB0,0x80,0x0,0x0,0x0,0x0,0x0,0x0,0x0,0x0,0x7,0x8B,0xBB,0xBB,
            0xBB,0xBB,0x80,0x0,0x0,0x0,0x0,0x0,0x0,0x0,0x0,0x0,0x0,0x70,0xBB,0xBB,0xBB,0xB0,0x0,0x0,
            0x0,0x0,0x0,0x0,0x0,0x0,0x0,0x0,0x0,0x0,0x70,0x0,0x0,0x70,0x0,0x0,0x0,0x0,0x0,0x0,
            0x0,0x0,0x0,0x0,0x0,0x0,0x0,0x0,0x0,0x0,0x0,0x0,0x0,0x0,0x0,0x0,0x0,0x0,0x0,0x0,
            0x0,0x0,0x0,0x0,0x0,0x0,0x0,0x0,0x0,0x0,0xFF,0xFF,0xFF,0xFF,0xFF,0xFF,0xFF,0xFF,0xFF,0xFF,
            0xFF,0xFF,0xF8,0x0,0x1F,0xFF,0xF8,0x0,0x1F,0xFF,0xF8,0x0,0x1F,0xFF,0xF8,0x0,0x1F,0xFF,0xF8,0x0,
            0x1F,0xFF,0xF8,0x0,0x1,0xFF,0xF8,0x0,0x1,0xFF,0xF8,0x0,0x1,0xFF,0xF8,0x0,0x1,0xFF,0xF8,0x0,
            0x1,0xFF,0xF8,0x0,0x1,0xFF,0xF8,0x0,0x1F,0xFF,0xF8,0x0,0x1,0xFF,0xF8,0x0,0x1,0xFF,0xF8,0x0,
            0x0,0xFF,0xF8,0x0,0x0,0x7F,0xF8,0x0,0x0,0x3F,0xF8,0x0,0x40,0x1F,0xFF,0xFF,0xF0,0x1F,0xFF,0xF0,
            0x38,0x1F,0xFF,0xF0,0x38,0x1F,0xFF,0xF0,0x38,0x1F,0xFF,0xF0,0x0,0x1F,0xFF,0xF0,0x0,0x1F,0xFF,0xF8,
            0x0,0x3F,0xFF,0xFC,0x0,0x7F,0xFF,0xFF,0x1,0xFF,0xFF,0xFF,0xFF,0xFF,0xFF,0xFF,0xFF,0xFF,0x28,0x0,
            0x0,0x0,0x10,0x0,0x0,0x0,0x20,0x0,0x0,0x0,0x1,0x0,0x4,0x0,0x0,0x0,0x0,0x0,0xC0,0x0,
            0x0,0x0,0x0,0x0,0x0,0x0,0x0,0x0,0x0,0x0,0x0,0x0,0x0,0x0,0x0,0x0,0x0,0x0,0x0,0x0,
            0x0,0x0,0x0,0x0,0x80,0x0,0x0,0x80,0x0,0x0,0x0,0x80,0x80,0x0,0x80,0x0,0x0,0x0,0x80,0x0,
            0x80,0x0,0x80,0x80,0x0,0x0,0x80,0x80,0x80,0x0,0xC0,0xC0,0xC0,0x0,0x0,0x0,0xFF,0x0,0x0,0xFF,
            0x0,0x0,0x0,0xFF,0xFF,0x0,0xFF,0x0,0x0,0x0,0xFF,0x0,0xFF,0x0,0xFF,0xFF,0x0,0x0,0xFF,0xFF,
            0xFF,0x0,0x70,0x0,0x0,0x0,0x0,0x0,0x0,0x0,0x7F,0xFF,0xFF,0xFF,0x30,0x0,0x30,0x0,0x7F,0xFF,
            0xFF,0xFF,0xB,0xBB,0x0,0x0,0x7F,0xF7,0x77,0x7F,0xB,0xBB,0x0,0x0,0x7F,0xFF,0xFF,0xFF,0x30,0x0,
            0x30,0x0,0x7F,0xF7,0x77,0x7F,0xF0,0x0,0x0,0x0,0x7F,0xFF,0xFF,0xFF,0x37,0x77,0x70,0x0,0x7F,0xF7,
            0x77,0x7F,0x3B,0xB8,0x0,0x0,0x7F,0xFF,0xFF,0x70,0x3B,0xBB,0x80,0x0,0x7F,0xFF,0xFF,0xFF,0x40,0xBB,
            0xB8,0x0,0x7F,0xFF,0x80,0x0,0x37,0xB,0xBB,0x0,0x77,0x77,0x70,0xBB,0x87,0x78,0xBB,0x0,0x0,0x0,
            0x3,0xBB,0xB3,0x3B,0xBB,0x0,0x0,0x0,0x0,0x3B,0xBB,0xBB,0xB8,0x70,0x0,0x0,0x0,0x3,0xBB,0xBB,
            0x83,0x0,0x0,0x0,0x0,0x0,0x33,0x33,0x30,0x0,0x0,0x3F,0x0,0x0,0x0,0x7,0x0,0x0,0x0,0x7,
            0x0,0x0,0x0,0x7,0x0,0x0,0x0,0x7,0x0,0x0,0x0,0x3F,0x0,0x0,0x0,0x7,0x0,0x0,0x0,0x7,
            0x0,0x0,0x0,0x3,0x0,0x0,0x0,0x1,0x0,0x0,0x0,0x1,0x0,0x0,0x0,0x1,0x0,0x0,0xF8,0x1,
            0x0,0x0,0xFC,0x1,0x0,0x0,0xFE,0x3,0x0,0x0,0xFF,0x7,0x0,0x0,0x28,0x0,0x0,0x0,0x30,0x0,
            0x0,0x0,0x60,0x0,0x0,0x0,0x1,0x0,0x8,0x0,0x0,0x0,0x0,0x0,0x80,0xA,0x0,0x0,0x0,0x0,
            0x0,0x0,0x0,0x0,0x0,0x0,0x0,0x0,0x0,0x0,0x0,0x0,0x0,0x0,0x0,0x0,0x0,0x0,0x0,0x0,
            0x80,0x0,0x0,0x80,0x0,0x0,0x0,0x80,0x80,0x0,0x80,0x0,0x0,0x0,0x80,0x0,0x80,0x0,0x80,0x80,
            0x0,0x0,0xC0,0xC0,0xC0,0x0,0xC0,0xDC,0xC0,0x0,0xF0,0xCA,0xA6,0x0,0x4,0x4,0x4,0x0,0x8,0x8,
            0x8,0x0,0xC,0xC,0xC,0x0,0x11,0x11,0x11,0x0,0x16,0x16,0x16,0x0,0x1C,0x1C,0x1C,0x0,0x22,0x22,
            0x22,0x0,0x29,0x29,0x29,0x0,0x55,0x55,0x55,0x0,0x4D,0x4D,0x4D,0x0,0x42,0x42,0x42,0x0,0x39,0x39,
            0x39,0x0,0x80,0x7C,0xFF,0x0,0x50,0x50,0xFF,0x0,0x93,0x0,0xD6,0x0,0xFF,0xEC,0xCC,0x0,0xC6,0xD6,
            0xEF,0x0,0xD6,0xE7,0xE7,0x0,0x90,0xA9,0xAD,0x0,0x0,0x0,0x33,0x0,0x0,0x0,0x66,0x0,0x0,0x0,
            0x99,0x0,0x0,0x0,0xCC,0x0,0x0,0x33,0x0,0x0,0x0,0x33,0x33,0x0,0x0,0x33,0x66,0x0,0x0,0x33,
            0x99,0x0,0x0,0x33,0xCC,0x0,0x0,0x33,0xFF,0x0,0x0,0x66,0x0,0x0,0x0,0x66,0x33,0x0,0x0,0x66,
            0x66,0x0,0x0,0x66,0x99,0x0,0x0,0x66,0xCC,0x0,0x0,0x66,0xFF,0x0,0x0,0x99,0x0,0x0,0x0,0x99,
            0x33,0x0,0x0,0x99,0x66,0x0,0x0,0x99,0x99,0x0,0x0,0x99,0xCC,0x0,0x0,0x99,0xFF,0x0,0x0,0xCC,
            0x0,0x0,0x0,0xCC,0x33,0x0,0x0,0xCC,0x66,0x0,0x0,0xCC,0x99,0x0,0x0,0xCC,0xCC,0x0,0x0,0xCC,
            0xFF,0x0,0x0,0xFF,0x66,0x0,0x0,0xFF,0x99,0x0,0x0,0xFF,0xCC,0x0,0x33,0x0,0x0,0x0,0x33,0x0,
            0x33,0x0,0x33,0x0,0x66,0x0,0x33,0x0,0x99,0x0,0x33,0x0,0xCC,0x0,0x33,0x0,0xFF,0x0,0x33,0x33,
            0x0,0x0,0x33,0x33,0x33,0x0,0x33,0x33,0x66,0x0,0x33,0x33,0x99,0x0,0x33,0x33,0xCC,0x0,0x33,0x33,
            0xFF,0x0,0x33,0x66,0x0,0x0,0x33,0x66,0x33,0x0,0x33,0x66,0x66,0x0,0x33,0x66,0x99,0x0,0x33,0x66,
            0xCC,0x0,0x33,0x66,0xFF,0x0,0x33,0x99,0x0,0x0,0x33,0x99,0x33,0x0,0x33,0x99,0x66,0x0,0x33,0x99,
            0x99,0x0,0x33,0x99,0xCC,0x0,0x33,0x99,0xFF,0x0,0x33,0xCC,0x0,0x0,0x33,0xCC,0x33,0x0,0x33,0xCC,
            0x66,0x0,0x33,0xCC,0x99,0x0,0x33,0xCC,0xCC,0x0,0x33,0xCC,0xFF,0x0,0x33,0xFF,0x33,0x0,0x33,0xFF,
            0x66,0x0,0x33,0xFF,0x99,0x0,0x33,0xFF,0xCC,0x0,0x33,0xFF,0xFF,0x0,0x66,0x0,0x0,0x0,0x66,0x0,
            0x33,0x0,0x66,0x0,0x66,0x0,0x66,0x0,0x99,0x0,0x66,0x0,0xCC,0x0,0x66,0x0,0xFF,0x0,0x66,0x33,
            0x0,0x0,0x66,0x33,0x33,0x0,0x66,0x33,0x66,0x0,0x66,0x33,0x99,0x0,0x66,0x33,0xCC,0x0,0x66,0x33,
            0xFF,0x0,0x66,0x66,0x0,0x0,0x66,0x66,0x33,0x0,0x66,0x66,0x66,0x0,0x66,0x66,0x99,0x0,0x66,0x66,
            0xCC,0x0,0x66,0x99,0x0,0x0,0x66,0x99,0x33,0x0,0x66,0x99,0x66,0x0,0x66,0x99,0x99,0x0,0x66,0x99,
            0xCC,0x0,0x66,0x99,0xFF,0x0,0x66,0xCC,0x0,0x0,0x66,0xCC,0x33,0x0,0x66,0xCC,0x99,0x0,0x66,0xCC,
            0xCC,0x0,0x66,0xCC,0xFF,0x0,0x66,0xFF,0x0,0x0,0x66,0xFF,0x33,0x0,0x66,0xFF,0x99,0x0,0x66,0xFF,
            0xCC,0x0,0xCC,0x0,0xFF,0x0,0xFF,0x0,0xCC,0x0,0x99,0x99,0x0,0x0,0x99,0x33,0x99,0x0,0x99,0x0,
            0x99,0x0,0x99,0x0,0xCC,0x0,0x99,0x0,0x0,0x0,0x99,0x33,0x33,0x0,0x99,0x0,0x66,0x0,0x99,0x33,
            0xCC,0x0,0x99,0x0,0xFF,0x0,0x99,0x66,0x0,0x0,0x99,0x66,0x33,0x0,0x99,0x33,0x66,0x0,0x99,0x66,
            0x99,0x0,0x99,0x66,0xCC,0x0,0x99,0x33,0xFF,0x0,0x99,0x99,0x33,0x0,0x99,0x99,0x66,0x0,0x99,0x99,
            0x99,0x0,0x99,0x99,0xCC,0x0,0x99,0x99,0xFF,0x0,0x99,0xCC,0x0,0x0,0x99,0xCC,0x33,0x0,0x66,0xCC,
            0x66,0x0,0x99,0xCC,0x99,0x0,0x99,0xCC,0xCC,0x0,0x99,0xCC,0xFF,0x0,0x99,0xFF,0x0,0x0,0x99,0xFF,
            0x33,0x0,0x99,0xCC,0x66,0x0,0x99,0xFF,0x99,0x0,0x99,0xFF,0xCC,0x0,0x99,0xFF,0xFF,0x0,0xCC,0x0,
            0x0,0x0,0x99,0x0,0x33,0x0,0xCC,0x0,0x66,0x0,0xCC,0x0,0x99,0x0,0xCC,0x0,0xCC,0x0,0x99,0x33,
            0x0,0x0,0xCC,0x33,0x33,0x0,0xCC,0x33,0x66,0x0,0xCC,0x33,0x99,0x0,0xCC,0x33,0xCC,0x0,0xCC,0x33,
            0xFF,0x0,0xCC,0x66,0x0,0x0,0xCC,0x66,0x33,0x0,0x99,0x66,0x66,0x0,0xCC,0x66,0x99,0x0,0xCC,0x66,
            0xCC,0x0,0x99,0x66,0xFF,0x0,0xCC,0x99,0x0,0x0,0xCC,0x99,0x33,0x0,0xCC,0x99,0x66,0x0,0xCC,0x99,
            0x99,0x0,0xCC,0x99,0xCC,0x0,0xCC,0x99,0xFF,0x0,0xCC,0xCC,0x0,0x0,0xCC,0xCC,0x33,0x0,0xCC,0xCC,
            0x66,0x0,0xCC,0xCC,0x99,0x0,0xCC,0xCC,0xCC,0x0,0xCC,0xCC,0xFF,0x0,0xCC,0xFF,0x0,0x0,0xCC,0xFF,
            0x33,0x0,0x99,0xFF,0x66,0x0,0xCC,0xFF,0x99,0x0,0xCC,0xFF,0xCC,0x0,0xCC,0xFF,0xFF,0x0,0xCC,0x0,
            0x33,0x0,0xFF,0x0,0x66,0x0,0xFF,0x0,0x99,0x0,0xCC,0x33,0x0,0x0,0xFF,0x33,0x33,0x0,0xFF,0x33,
            0x66,0x0,0xFF,0x33,0x99,0x0,0xFF,0x33,0xCC,0x0,0xFF,0x33,0xFF,0x0,0xFF,0x66,0x0,0x0,0xFF,0x66,
            0x33,0x0,0xCC,0x66,0x66,0x0,0xFF,0x66,0x99,0x0,0xFF,0x66,0xCC,0x0,0xCC,0x66,0xFF,0x0,0xFF,0x99,
            0x0,0x0,0xFF,0x99,0x33,0x0,0xFF,0x99,0x66,0x0,0xFF,0x99,0x99,0x0,0xFF,0x99,0xCC,0x0,0xFF,0x99,
            0xFF,0x0,0xFF,0xCC,0x0,0x0,0xFF,0xCC,0x33,0x0,0xFF,0xCC,0x66,0x0,0xFF,0xCC,0x99,0x0,0xFF,0xCC,
            0xCC,0x0,0xFF,0xCC,0xFF,0x0,0xFF,0xFF,0x33,0x0,0xCC,0xFF,0x66,0x0,0xFF,0xFF,0x99,0x0,0xFF,0xFF,
            0xCC,0x0,0x66,0x66,0xFF,0x0,0x66,0xFF,0x66,0x0,0x66,0xFF,0xFF,0x0,0xFF,0x66,0x66,0x0,0xFF,0x66,
            0xFF,0x0,0xFF,0xFF,0x66,0x0,0x21,0x0,0xA5,0x0,0x5F,0x5F,0x5F,0x0,0x77,0x77,0x77,0x0,0x86,0x86,
            0x86,0x0,0x96,0x96,0x96,0x0,0xCB,0xCB,0xCB,0x0,0xB2,0xB2,0xB2,0x0,0xD7,0xD7,0xD7,0x0,0xDD,0xDD,
            0xDD,0x0,0xE3,0xE3,0xE3,0x0,0xEA,0xEA,0xEA,0x0,0xF1,0xF1,0xF1,0x0,0xF8,0xF8,0xF8,0x0,0xF0,0xFB,
            0xFF,0x0,0xA4,0xA0,0xA0,0x0,0x80,0x80,0x80,0x0,0x0,0x0,0xFF,0x0,0x0,0xFF,0x0,0x0,0x0,0xFF,
            0xFF,0x0,0xFF,0x0,0x0,0x0,0xFF,0x0,0xFF,0x0,0xFF,0xFF,0x0,0x0,0xFF,0xFF,0xFF,0x0,0x0,0x0,
            0x0,0x0,0x0,0x0,0x0,0x0,0x0,0x0,0x0,0x0,0x0,0x0,0x0,0x0,0x0,0x0,0x0,0x0,0x0,0x0,
            0x0,0x0,0x0,0x0,0x0,0x0,0x0,0x0,0x0,0x0,0x0,0x0,0x0,0x0,0x0,0x0,0x0,0x0,0x0,0x0,
            0x0,0x0,0x0,0x0,0x0,0x0,0x0,0x0,0x0,0x0,0x0,0x0,0x0,0x0,0x0,0x0,0x0,0x0,0x0,0x0,
            0x0,0x0,0x0,0x0,0x0,0x0,0x0,0x0,0x0,0x0,0x0,0x0,0x0,0x0,0x0,0x0,0x0,0x0,0x0,0x0,
            0x0,0x0,0x0,0x0,0x0,0x0,0x0,0x0,0x0,0x0,0x0,0x0,0x0,0x0,0x0,0x0,0x0,0x0,0x0,0x0,
            0x0,0x0,0x0,0x0,0x0,0x0,0x0,0x0,0x0,0x0,0x0,0x0,0x0,0x0,0x0,0x0,0x0,0x0,0x0,0x0,
            0x0,0x0,0x0,0x0,0x0,0x0,0x0,0x0,0x0,0x0,0x0,0x0,0x0,0x0,0x0,0x0,0x0,0x0,0x0,0x0,
            0x0,0x0,0x0,0x0,0x0,0x0,0x0,0x0,0x0,0x0,0x0,0x0,0x0,0x0,0x0,0x0,0x0,0x0,0x0,0x0,
            0x0,0x0,0x0,0x0,0x0,0x0,0x0,0x0,0x0,0x0,0x0,0x0,0x0,0x0,0x0,0x0,0x0,0x0,0x0,0x0,
            0x0,0x0,0x0,0x0,0x0,0x0,0x0,0x0,0x0,0x0,0x0,0x0,0x0,0x0,0x0,0x0,0x0,0x0,0x0,0x0,
            0x0,0x0,0x0,0x0,0x0,0x0,0x0,0x0,0x0,0x0,0x0,0x0,0x0,0x0,0x0,0x0,0x0,0x0,0x0,0x0,
            0x0,0x0,0x0,0x0,0x0,0x0,0x0,0x0,0x0,0x0,0x0,0x0,0x0,0x0,0x0,0x0,0x0,0x0,0x0,0x0,
            0x0,0x0,0x0,0x0,0x0,0xF8,0x0,0x0,0x0,0x0,0x0,0x0,0x0,0x0,0x0,0x0,0x0,0x0,0x0,0x0,
            0x0,0x0,0x0,0x0,0x0,0x0,0x0,0x0,0x0,0x0,0x0,0x0,0x0,0x0,0x0,0x0,0x0,0x0,0x0,0x0,
            0x0,0x0,0x0,0x0,0x0,0x0,0x0,0x0,0x0,0x0,0x0,0x0,0x0,0xF8,0x7,0x7,0x7,0x7,0x7,0x7,
            0x7,0x7,0x7,0x7,0x7,0x7,0x7,0x7,0x7,0x7,0x7,0x7,0x7,0x7,0x7,0x0,0x0,0x0,0x0,0x0,
            0x0,0x0,0x0,0x0,0x0,0x0,0x0,0x0,0x0,0x0,0x0,0x0,0x0,0x0,0x0,0x0,0x0,0x0,0x0,0x0,
            0x0,0xF8,0x7,0xFF,0xFF,0xFF,0xFF,0xFF,0xFF,0xFF,0xFF,0xFF,0xFF,0xFF,0xFF,0xFF,0xFF,0xFF,0xFF,0xFF,
            0xFF,0xFF,0x7,0x0,0x0,0x0,0x0,0x0,0x0,0x0,0x0,0x0,0x0,0x0,0x0,0x0,0x0,0x0,0x0,0x0,
            0x0,0x0,0x0,0x0,0x0,0x0,0x0,0x0,0x0,0xF8,0x7,0xFF,0xFF,0xFF,0xFF,0xFF,0xFF,0xFF,0xFF,0xFF,
            0xFF,0xFF,0xFF,0xFF,0xFF,0xFF,0xFF,0xFF,0xFF,0xFF,0x7,0x0,0x0,0x0,0x0,0x0,0x0,0x0,0x0,0x0,
            0x0,0x0,0x0,0x0,0x0,0x0,0x0,0x0,0x0,0x0,0x0,0x0,0x0,0x0,0x0,0x0,0x0,0xF8,0x7,0xFF,
            0xFF,0xFF,0xFF,0xFF,0xFF,0xFF,0xFF,0xFF,0xFF,0xFF,0xFF,0xFF,0xFF,0xFF,0xFF,0xFF,0xFF,0xFF,0x7,0x0,
            0x0,0x0,0x0,0x0,0x0,0x0,0x0,0x0,0x0,0x0,0x0,0x0,0x0,0x0,0x0,0x0,0x0,0x0,0x0,0x0,
            0x0,0x0,0x0,0x0,0x0,0xF8,0x7,0xFF,0xFF,0xFF,0xEE,0xEE,0xEE,0xEE,0xEE,0xEE,0xEE,0xEE,0xEE,0xEE,
            0xEE,0xEE,0xEE,0xFF,0xFF,0xFF,0x7,0x0,0x0,0x0,0x0,0x0,0x0,0x0,0x0,0x0,0x0,0x0,0x0,0x0,
            0x0,0x0,0x0,0x0,0x0,0x0,0x0,0x0,0x0,0x0,0x0,0x0,0x0,0xF8,0x7,0xFF,0xFF,0xFF,0xED,0xED,
            0xED,0xED,0xED,0xED,0xED,0xED,0xED,0xED,0xED,0xED,0xED,0xFF,0xFF,0xFF,0x7,0x0,0x0,0x0,0x0,0x0,
            0x0,0x0,0x0,0x0,0x0,0x0,0x0,0x0,0x0,0x0,0x0,0x0,0x0,0x0,0x0,0x0,0x0,0x0,0x0,0x0,
            0x0,0xF8,0x7,0xFF,0xFF,0xFF,0xFF,0xFF,0xFF,0xFF,0xFF,0xFF,0xFF,0xFF,0xFF,0xFF,0xFF,0xFF,0xFF,0xFF,
            0xFF,0xFF,0x7,0x0,0x0,0x0,0x0,0x0,0x0,0x0,0x0,0x0,0x0,0x0,0x0,0x0,0x0,0x0,0x0,0x0,
            0x0,0x0,0x0,0x0,0x0,0x0,0x0,0x0,0x0,0xF8,0x7,0xFF,0xFF,0xFF,0xFF,0xFF,0xFF,0xFF,0xFF,0xFF,
            0xFF,0xFF,0xFF,0xFF,0xFF,0xFF,0xFF,0xFF,0xF8,0x0,0x0,0x0,0x0,0x0,0x0,0x0,0x0,0x0,0x0,0x0,
            0x0,0x0,0x0,0x0,0x0,0x0,0x0,0x0,0x0,0x0,0x0,0x0,0x0,0x0,0x0,0x0,0x0,0xF8,0x7,0xFF,
            0xFF,0xFF,0xEE,0xEE,0xEE,0xEE,0xEE,0xEE,0xEE,0xEE,0xEE,0xEE,0xEE,0xEE,0xEE,0xFF,0xF8,0x38,0xFB,0x38,
            0xFB,0x38,0xFB,0x38,0xFB,0x0,0x0,0x0,0x0,0x0,0x0,0x0,0x0,0x0,0x0,0x0,0x0,0x0,0x0,0x0,
            0x0,0x0,0x0,0x0,0x0,0xF8,0x7,0xFF,0xFF,0xFF,0xED,0xED,0xED,0xED,0xED,0xED,0xED,0xED,0xED,0xED,
            0xED,0xED,0xEE,0xFF,0xF8,0xFB,0x38,0xFB,0x38,0xFB,0x38,0xFB,0x38,0x0,0x0,0x0,0x0,0x0,0x0,0x0,
            0x0,0x0,0x0,0x0,0x0,0x0,0x0,0x0,0x0,0x0,0x0,0x0,0x0,0xF8,0x7,0xFF,0xFF,0xFF,0xFF,0xFF,
            0xFF,0xFF,0xFF,0xFF,0xFF,0xFF,0xFF,0xFF,0xFF,0xFF,0xFF,0xFF,0xF8,0x38,0xFB,0x38,0xFB,0x38,0xFB,0x38,
            0xFB,0x0,0x0,0x0,0x0,0x0,0x0,0x0,0x0,0x0,0x0,0x0,0x0,0x0,0x0,0x0,0x0,0x0,0x0,0x0,
            0x0,0xF8,0x7,0xFF,0xFF,0xFF,0xFF,0xFF,0xFF,0xFF,0xFF,0xFF,0xFF,0xFF,0xFF,0xFF,0xFF,0xFF,0xFF,0xFF,
            0xF8,0xFB,0x38,0xFB,0x38,0xFB,0x38,0xFB,0x38,0x0,0x0,0x0,0x0,0x0,0x0,0x0,0x0,0x0,0x0,0x0,
            0x0,0x0,0x0,0x0,0x0,0x0,0x0,0x0,0x0,0xF8,0x7,0xFF,0xFF,0xFF,0xEE,0xEE,0xEE,0xEE,0xEE,0xEE,
            0xEE,0xEE,0xEE,0xEE,0xEE,0xEE,0xEE,0xFF,0xF8,0x38,0xFB,0x38,0xFB,0x38,0xFB,0x38,0xFB,0x0,0x0,0x0,
            0x0,0x0,0x0,0x0,0x0,0x0,0x0,0x0,0x0,0x0,0x0,0x0,0x0,0x0,0x0,0x0,0x0,0xF8,0x7,0xFF,
            0xFF,0xFF,0xED,0xED,0xED,0xED,0xED,0xED,0xED,0xED,0xED,0xED,0xED,0xED,0xEE,0xFF,0xF8,0xFB,0x38,0xFB,
            0x38,0xFB,0x38,0xFB,0x38,0x0,0x0,0x0,0x0,0x0,0x0,0x0,0x0,0x0,0x0,0x0,0x0,0x0,0x0,0x0,
            0x0,0x0,0x0,0x0,0x0,0xF8,0x7,0xFF,0xFF,0xFF,0xFF,0xFF,0xFF,0xFF,0xFF,0xFF,0xFF,0xFF,0xFF,0xFF,
            0xFF,0xFF,0xFF,0xFF,0xF8,0xF8,0xF8,0xF8,0xF8,0xF8,0xF8,0xF8,0xF8,0xF8,0x0,0x0,0x0,0x0,0x0,0x0,
            0x0,0x0,0x0,0x0,0x0,0x0,0x0,0x0,0x0,0x0,0x0,0x0,0x0,0xF8,0x7,0xFF,0xFF,0xFF,0xFF,0xFF,
            0xFF,0xFF,0xFF,0xFF,0xFF,0xFF,0xFF,0xFF,0xFF,0xFF,0xFF,0xFF,0xFF,0xFF,0xFF,0xF8,0x0,0x0,0x0,0x0,
            0x0,0x0,0x0,0x0,0x0,0x0,0x0,0x0,0x0,0x0,0x0,0x0,0x0,0x0,0x0,0x0,0x0,0x0,0x0,0x0,
            0x0,0xF8,0x7,0xFF,0xFF,0xFF,0xEE,0xEE,0xEE,0xEE,0xEE,0xEE,0xEE,0xEE,0xEE,0xEE,0xEE,0xEE,0xEE,0xFF,
            0xFF,0xFF,0xFF,0xF8,0x0,0x0,0x0,0x0,0x0,0x0,0x0,0x0,0x0,0x0,0x0,0x0,0x0,0x0,0x0,0x0,
            0x0,0x0,0x0,0x0,0x0,0x0,0x0,0x0,0x0,0xF8,0x7,0xFF,0xFF,0xFF,0xED,0xED,0xED,0xED,0xED,0xED,
            0xED,0xED,0xED,0xED,0xED,0xED,0xEE,0xFF,0x0,0x0,0x0,0x0,0x0,0x0,0x0,0x0,0x0,0x0,0x0,0x0,
            0x0,0x0,0x0,0x0,0x0,0x0,0x0,0x0,0x0,0x0,0x0,0x0,0x0,0x0,0x0,0x0,0x0,0xF8,0x7,0xFF,
            0xFF,0xFF,0xFF,0xFF,0xFF,0xFF,0xFF,0xFF,0xFF,0xFF,0xFF,0xFF,0xFF,0xFF,0xFF,0xFF,0xEC,0x38,0xFB,0x38,
            0xFB,0x38,0xFB,0x38,0x0,0x0,0x0,0x0,0x0,0x0,0x0,0x0,0x0,0x0,0x0,0x0,0x0,0x0,0x0,0x0,
            0x0,0x0,0x0,0x0,0x0,0xF8,0x7,0xFF,0xFF,0xFF,0xFF,0xFF,0xFF,0xFF,0xFF,0xFF,0xFF,0xFF,0xFF,0xFF,
            0xFF,0xF8,0xF8,0xF8,0xEC,0xFB,0x38,0xFB,0x38,0xFB,0x38,0xFB,0xF8,0x0,0x0,0x0,0x0,0x0,0x0,0x0,
            0x0,0x0,0x0,0x0,0x0,0x0,0x0,0x0,0x0,0x0,0x0,0x0,0x0,0xF8,0x7,0xFF,0xFF,0xFF,0xFF,0xFF,
            0xFF,0xFF,0xFF,0xFF,0xFF,0xFF,0xFF,0xFF,0xFF,0x7,0xFF,0xFF,0xEC,0x38,0xFB,0x38,0xFB,0x38,0xFB,0x38,
            0x38,0x0,0x0,0x0,0x0,0x0,0x0,0x0,0x0,0x0,0x0,0x0,0x0,0x0,0x0,0x0,0x0,0x0,0x0,0x0,
            0x0,0xF8,0x7,0xFF,0xFF,0xFF,0xFF,0xFF,0xFF,0xFF,0xFF,0xFF,0xFF,0xFF,0xFF,0xFF,0xFF,0x7,0xFF,0xFF,
            0xFF,0xEC,0x38,0xFB,0x38,0xFB,0x38,0xFB,0x38,0x38,0xF8,0xF8,0x0,0x0,0x0,0x0,0x0,0x0,0x0,0x0,
            0x0,0x0,0x0,0x0,0x0,0x0,0x0,0x0,0x0,0xF8,0x7,0xFF,0xFF,0xFF,0xFF,0xFF,0xFF,0xFF,0xFF,0xFF,
            0xFF,0xFF,0xFF,0xFF,0xFF,0x7,0xFF,0xFF,0x7,0xEC,0x38,0x38,0xFB,0x38,0xFB,0x38,0xFB,0x38,0x38,0x38,
            0xF8,0x0,0x0,0x0,0x0,0x0,0x0,0x0,0x0,0x0,0x0,0x0,0x0,0x0,0x0,0x0,0x0,0xF8,0x7,0x7,
            0x7,0x7,0x7,0x7,0x7,0x7,0x7,0x7,0x7,0x7,0x7,0x7,0x7,0x7,0x7,0x7,0x0,0x0,0xEC,0x38,
            0x38,0xFB,0x38,0xFB,0x38,0xFB,0x38,0xFB,0x38,0xF8,0x0,0x0,0x0,0x0,0x0,0x0,0x0,0x0,0x0,0x0,
            0x0,0x0,0x0,0x0,0x0,0xF8,0xF8,0xF8,0xF8,0xF8,0xF8,0xF8,0xF8,0xF8,0xF8,0xF8,0xF8,0xF8,0xF8,0xF8,
            0xF8,0xF8,0x0,0x0,0x0,0x0,0x0,0xEC,0xEC,0x38,0xFB,0x38,0xFB,0x38,0xFB,0x38,0xFB,0x38,0xF8,0x0,
            0x0,0x0,0x0,0x0,0x0,0x0,0x0,0x0,0x0,0x0,0x0,0x0,0x0,0x0,0x0,0x0,0x0,0x0,0x0,0x0,
            0x0,0x0,0x0,0x0,0x0,0x0,0x0,0x0,0x0,0x0,0x0,0x0,0x0,0x0,0x0,0x0,0x0,0xEC,0x38,0xFB,
            0x38,0xFB,0x38,0xFB,0x38,0x38,0xF8,0x0,0x0,0x0,0x0,0x0,0x0,0x0,0x0,0x0,0x0,0x0,0x0,0x0,
            0x0,0x0,0x0,0x0,0x0,0x0,0x0,0x0,0x0,0x0,0x0,0x0,0x0,0x0,0x0,0x0,0x0,0x0,0x0,0x0,
            0x0,0x0,0x0,0x0,0x0,0x0,0xEC,0x38,0xFB,0x38,0xFB,0x38,0xFB,0x38,0x38,0xEB,0x0,0x0,0x0,0x0,
            0x0,0x0,0x0,0x0,0x0,0x0,0x0,0x0,0x0,0x0,0x0,0x0,0x0,0x0,0x0,0x0,0x0,0x0,0x0,0x0,
            0x0,0x0,0x0,0x0,0x0,0x0,0x0,0x0,0x0,0x0,0x0,0x0,0x0,0x0,0x0,0xEC,0x38,0xFB,0x38,0xFB,
            0x38,0xFB,0x38,0xEB,0x0,0x0,0x0,0x0,0x0,0x0,0x0,0x0,0x0,0x0,0x0,0x0,0x0,0x0,0x0,0x0,
            0x0,0x0,0x0,0x0,0x0,0x0,0x0,0x0,0x0,0x0,0xEE,0xEE,0xEE,0xEE,0xEE,0xEE,0xEC,0xEC,0x0,0x0,
            0x0,0x0,0x0,0xEC,0xFB,0x38,0xFB,0x38,0xFB,0x38,0xFB,0xEB,0x0,0x0,0x0,0x0,0x0,0x0,0x0,0x0,
            0x0,0x0,0x0,0x0,0x0,0x0,0x0,0x0,0x0,0x0,0x0,0x0,0x0,0x0,0x0,0x0,0x0,0x0,0xEE,0x38,
            0x38,0xFB,0x38,0xFB,0x38,0xEC,0x0,0x0,0x0,0x0,0x0,0xEC,0x38,0xFB,0x38,0xFB,0x38,0xFB,0x38,0xEB,
            0x0,0x0,0x0,0x0,0x0,0x0,0x0,0x0,0x0,0x0,0x0,0x0,0x0,0x0,0x0,0x0,0x0,0x0,0x0,0x0,
            0x0,0x0,0x0,0x0,0x0,0x0,0xEE,0x38,0xFB,0x38,0xFB,0x38,0xFB,0xEC,0x0,0x0,0x0,0x0,0x0,0xEC,
            0xFB,0x38,0xFB,0x38,0xFB,0x38,0xFB,0xEB,0x0,0x0,0x0,0x0,0x0,0x0,0x0,0x0,0x0,0x0,0x0,0x0,
            0x0,0x0,0x0,0x0,0x0,0x0,0x0,0x0,0x0,0x0,0x0,0x0,0x0,0x0,0xEE,0x38,0x38,0xFB,0x38,0xFB,
            0x38,0x38,0xEC,0x0,0x0,0x0,0x0,0xEC,0x38,0xFB,0x38,0xFB,0x38,0xFB,0x38,0xEB,0x0,0x0,0x0,0x0,
            0x0,0x0,0x0,0x0,0x0,0x0,0x0,0x0,0x0,0x0,0x0,0x0,0x0,0x0,0x0,0x0,0x0,0x0,0x0,0x0,
            0x0,0x0,0x0,0xEE,0xFB,0x38,0xFB,0x38,0xFB,0x38,0x38,0xEC,0xEC,0xEC,0xEC,0x38,0xFB,0x38,0xFB,0x38,
            0xFB,0x38,0x38,0xEB,0x0,0x0,0x0,0x0,0x0,0x0,0x0,0x0,0x0,0x0,0x0,0x0,0x0,0x0,0x0,0x0,
            0x0,0x0,0x0,0x0,0x0,0x0,0x0,0x0,0x0,0x0,0x0,0xEE,0x38,0xFB,0x38,0xFB,0x38,0xFB,0x38,0xFB,
            0x38,0xFB,0x38,0xFB,0x38,0xFB,0x38,0xFB,0x38,0xFB,0xEB,0x0,0x0,0x0,0x0,0x0,0x0,0x0,0x0,0x0,
            0x0,0x0,0x0,0x0,0x0,0x0,0x0,0x0,0x0,0x0,0x0,0x0,0x0,0x0,0x0,0x0,0x0,0x0,0x0,0x0,
            0xEE,0x38,0xFB,0x38,0xFB,0x38,0xFB,0x38,0xFB,0x38,0xFB,0x38,0xFB,0x38,0xFB,0x38,0xFB,0x38,0xEB,0x0,
            0x0,0x0,0x0,0x0,0x0,0x0,0x0,0x0,0x0,0x0,0x0,0x0,0x0,0x0,0x0,0x0,0x0,0x0,0x0,0x0,
            0x0,0x0,0x0,0x0,0x0,0x0,0x0,0x0,0x0,0xEE,0x38,0xFB,0x38,0xFB,0x38,0xFB,0x38,0xFB,0x38,0xFB,
            0x38,0xFB,0x38,0xFB,0x38,0xED,0x0,0x0,0x0,0x0,0x0,0x0,0x0,0x0,0x0,0x0,0x0,0x0,0x0,0x0,
            0x0,0x0,0x0,0x0,0x0,0x0,0x0,0x0,0x0,0x0,0x0,0x0,0x0,0x0,0x0,0x0,0x0,0x0,0xEE,0x38,
            0xFB,0x38,0xFB,0x38,0xFB,0x38,0xFB,0x38,0xFB,0x38,0xFB,0x38,0xED,0x0,0x0,0x0,0x0,0x0,0x0,0x0,
            0x0,0x0,0x0,0x0,0x0,0x0,0x0,0x0,0x0,0x0,0x0,0x0,0x0,0x0,0x0,0x0,0x0,0x0,0x0,0x0,
            0x0,0x0,0x0,0x0,0x0,0x0,0x0,0xEE,0xEE,0x38,0x38,0xFB,0x38,0xFB,0x38,0xFB,0x38,0x38,0xEE,0xEE,
            0x0,0x0,0x0,0x0,0x0,0x0,0x0,0x0,0x0,0x0,0x0,0x0,0x0,0x0,0x0,0x0,0x0,0x0,0x0,0x0,
            0x0,0x0,0x0,0x0,0x0,0x0,0x0,0x0,0x0,0x0,0x0,0x0,0x0,0x0,0x0,0x0,0x0,0xEE,0xEE,0xEE,
            0xEE,0xEE,0xEE,0xEE,0xEE,0xEE,0x0,0x0,0x0,0x0,0x0,0x0,0x0,0x0,0x0,0x0,0x0,0x0,0x0,0x0,
            0x0,0x0,0x0,0x0,0x0,0x0,0x0,0x0,0x0,0x0,0x0,0x0,0x0,0x0,0x0,0x0,0x0,0x0,0x0,0x0,
            0x0,0x0,0x0,0x0,0x0,0x0,0x0,0x0,0x0,0x0,0x0,0x0,0x0,0x0,0x0,0x0,0x0,0x0,0x0,0x0,
            0x0,0x0,0x0,0x0,0x0,0x0,0x0,0x0,0x0,0x0,0x0,0x0,0x0,0x0,0x0,0x0,0x0,0x0,0x0,0x0,
            0x0,0x0,0x0,0x0,0x0,0x0,0x0,0x0,0x0,0x0,0x0,0x0,0x0,0x0,0x0,0x0,0x0,0x0,0x0,0x0,
            0x0,0x0,0x0,0x0,0x0,0x0,0x0,0x0,0x0,0x0,0x0,0x0,0x0,0x0,0x0,0x0,0x0,0x0,0x0,0x0,
            0x0,0x0,0x0,0x0,0x0,0x0,0x0,0x0,0x0,0x0,0x0,0x0,0x0,0x0,0x0,0x0,0x0,0x0,0x0,0x0,
            0x0,0x0,0x0,0x0,0x0,0x0,0x0,0x0,0x0,0x0,0x0,0x0,0x0,0x0,0x0,0x0,0x0,0x0,0x0,0x0,
            0x0,0x0,0xFF,0xFF,0xFF,0xFF,0xFF,0xFF,0x0,0x0,0xFF,0xFF,0xFF,0xFF,0xFF,0xFF,0x0,0x0,0xFF,0xFF,
            0xFF,0xFF,0xFF,0xFF,0x0,0x0,0xFF,0xFF,0xFF,0xFF,0xFF,0xFF,0x0,0x0,0xFF,0xFF,0xFF,0xFF,0xFF,0xFF,
            0x0,0x0,0xFE,0x0,0x0,0x3,0xFF,0xFF,0x0,0x0,0xFE,0x0,0x0,0x3,0xFF,0xFF,0x0,0x0,0xFE,0x0,
            0x0,0x3,0xFF,0xFF,0x0,0x0,0xFE,0x0,0x0,0x3,0xFF,0xFF,0x0,0x0,0xFE,0x0,0x0,0x3,0xFF,0xFF,
            0x0,0x0,0xFE,0x0,0x0,0x3,0xFF,0xFF,0x0,0x0,0xFE,0x0,0x0,0x3,0xFF,0xFF,0x0,0x0,0xFE,0x0,
            0x0,0x3,0xFF,0xFF,0x0,0x0,0xFE,0x0,0x0,0x0,0xF,0xFF,0x0,0x0,0xFE,0x0,0x0,0x0,0xF,0xFF,
            0x0,0x0,0xFE,0x0,0x0,0x0,0xF,0xFF,0x0,0x0,0xFE,0x0,0x0,0x0,0xF,0xFF,0x0,0x0,0xFE,0x0,
            0x0,0x0,0xF,0xFF,0x0,0x0,0xFE,0x0,0x0,0x0,0xF,0xFF,0x0,0x0,0xFE,0x0,0x0,0x0,0xF,0xFF,
            0x0,0x0,0xFE,0x0,0x0,0x0,0xF,0xFF,0x0,0x0,0xFE,0x0,0x0,0x3,0xFF,0xFF,0x0,0x0,0xFE,0x0,
            0x0,0x3,0xFF,0xFF,0x0,0x0,0xFE,0x0,0x0,0x0,0x1F,0xFF,0x0,0x0,0xFE,0x0,0x0,0x0,0x1F,0xFF,
            0x0,0x0,0xFE,0x0,0x0,0x0,0x1F,0xFF,0x0,0x0,0xFE,0x0,0x0,0x0,0xF,0xFF,0x0,0x0,0xFE,0x0,
            0x0,0x0,0x3,0xFF,0x0,0x0,0xFE,0x0,0x0,0x0,0x1,0xFF,0x0,0x0,0xFE,0x0,0x0,0x30,0x0,0xFF,
            0x0,0x0,0xFE,0x0,0x0,0xF8,0x0,0x7F,0x0,0x0,0xFF,0xFF,0xFF,0xFE,0x0,0x7F,0x0,0x0,0xFF,0xFF,
            0xFF,0xFF,0x0,0x3F,0x0,0x0,0xFF,0xFF,0xFF,0xFF,0x80,0x3F,0x0,0x0,0xFF,0xFF,0xF0,0xF,0x80,0x3F,
            0x0,0x0,0xFF,0xFF,0xF0,0xF,0x80,0x3F,0x0,0x0,0xFF,0xFF,0xF0,0xF,0x80,0x3F,0x0,0x0,0xFF,0xFF,
            0xF0,0x7,0x80,0x3F,0x0,0x0,0xFF,0xFF,0xF8,0x0,0x0,0x3F,0x0,0x0,0xFF,0xFF,0xF8,0x0,0x0,0x7F,
            0x0,0x0,0xFF,0xFF,0xFC,0x0,0x0,0x7F,0x0,0x0,0xFF,0xFF,0xFE,0x0,0x0,0xFF,0x0,0x0,0xFF,0xFF,
            0xFF,0x0,0x1,0xFF,0x0,0x0,0xFF,0xFF,0xFF,0x80,0x3,0xFF,0x0,0x0,0xFF,0xFF,0xFF,0xE0,0xF,0xFF,
            0x0,0x0,0xFF,0xFF,0xFF,0xFF,0xFF,0xFF,0x0,0x0,0xFF,0xFF,0xFF,0xFF,0xFF,0xFF,0x0,0x0,0xFF,0xFF,
            0xFF,0xFF,0xFF,0xFF,0x0,0x0
        };
    }
}
