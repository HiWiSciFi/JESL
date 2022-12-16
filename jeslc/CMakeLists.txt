add_executable(jeslc)

	set_property(TARGET jeslc PROPERTY CXX_STANDARD 17)

	set(SRC_DIR "${CMAKE_CURRENT_SOURCE_DIR}/src")

	target_sources(jeslc
		PRIVATE
			"${SRC_DIR}/Jeslc.cpp"
			"${SRC_DIR}/Jeslc.hpp"
			"${SRC_DIR}/SPIRV/Instructions.hpp"
	)
